using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using HardCiter.Service.Configuration;
using HardCiter.Service.Converters;
using HardCiter.Service.Filters;
using HardCiter.Service.Middleware;
using HardCiter.Service.Models;

namespace HardCiter.Service
{

    /// <summary>
    /// Configures the service at startup.
    /// </summary>
    public class Startup
    {

        #region Constructors

        /// <summary>
        /// Initializes the service startup manager.
        /// </summary>
        /// <param name="configuration">
        /// The service's configuration.
        /// </param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #endregion

        #region Properties

        /// <summary>
        /// The service's configuration.
        /// </summary>
        /// <value>
        /// The service's configuration.
        /// </value>
        public IConfiguration Configuration { get; private set; }

        #endregion

        #region Methods

        /// <summary>
        /// Configures the service.
        /// </summary>
        /// <param name="serviceCollection">
        /// A collection of service features.
        /// </param>
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvc()
                             .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                             .AddJsonOptions(options =>
                             {
                                 options.SerializerSettings.Converters.Add(new ContentItemConverter());
                             });
            serviceCollection.AddNodeServices();
            serviceCollection.Configure<Settings>(Configuration.GetSection(nameof(Settings)));
            serviceCollection.AddSwaggerGen(options =>
            {
                options.SwaggerDoc(Settings.Version, Settings.ToInfo());
                options.DescribeAllEnumsAsStrings();
                options.OperationFilter<SwaggerConsumesFilter>();
                options.OperationFilter<SwaggerProducesFilter>();
                options.DocumentFilter<PolymorphismDocumentFilter>(typeof(ContentItem), ContentItem.Discriminator);
                options.DocumentFilter<PolymorphismDocumentFilter>(typeof(Article), Article.Discriminator);
                options.DocumentFilter<PolymorphismDocumentFilter>(typeof(BookBase), BookBase.Discriminator);
                options.SchemaFilter<PolymorphismSchemaFilter>(typeof(ContentItem));
                options.SchemaFilter<PolymorphismSchemaFilter>(typeof(Article));
                options.SchemaFilter<PolymorphismSchemaFilter>(typeof(BookBase));
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));
            });
        }

        /// <summary>
        /// Configures the service.
        /// </summary>
        /// <param name="applicationBuilder">
        /// The IApplicationBuilder used in the service.
        /// </param>
        public static void Configure(IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.UseHsts();
            applicationBuilder.UseHttpsRedirection();
            applicationBuilder.UseDefaultFiles(new DefaultFilesOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Documentation")),
                RequestPath = string.Empty
            });
            applicationBuilder.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Documentation")),
                RequestPath = string.Empty
            });
            applicationBuilder.UseSwagger();
            applicationBuilder.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint(Settings.Schema, Settings.Name);
            });
            applicationBuilder.UseMiddleware(typeof(ErrorHandlingMiddleware));
            applicationBuilder.UseMvc();
        }

        #endregion

    }

}