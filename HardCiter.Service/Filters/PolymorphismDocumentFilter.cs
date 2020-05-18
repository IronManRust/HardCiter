using System;
using System.Collections.Generic;
using System.Linq;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HardCiter.Service.Filters
{

    /// <summary>
    /// Filters Swagger documents.
    /// </summary>
    public class PolymorphismDocumentFilter : IDocumentFilter
    {

        #region Variables

        private Type _type;
        private string _discriminator;

        #endregion

        #region Constructors

        /// <summary>
        /// Applies the associated Swagger filter.
        /// </summary>
        /// <param name="type">
        /// The type to add polymorphism information about.
        /// </param>
        /// <param name="discriminator">
        /// The field that discriminates derived types from each other.
        /// </param>
        public PolymorphismDocumentFilter(Type type, string discriminator)
        {
            _type = type;
            _discriminator = discriminator;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Applies the associated Swagger filter.
        /// </summary>
        /// <param name="swaggerDocument">
        /// The current Swagger document.
        /// </param>
        /// <param name="context">
        /// The current context.
        /// </param>
        public void Apply(SwaggerDocument swaggerDocument, DocumentFilterContext context)
        {
            if (context != null)
            {
                ISchemaRegistry schemaRegistry = context.SchemaRegistry;
                Schema schema = schemaRegistry.Definitions[_type.Name];

                schema.Discriminator = _discriminator;
                if (!schema.Properties.ContainsKey(_discriminator))
                {
                    schema.Properties.Add(_discriminator, new Schema { Type = "string" });
                }

                _type.Assembly.GetTypes()
                              .Where(x => _type != x && _type.IsAssignableFrom(x))
                              .ToList()
                              .ForEach(x => schemaRegistry.GetOrRegister(x));
            }
        }

        #endregion

    }

}