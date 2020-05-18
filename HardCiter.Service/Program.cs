using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HardCiter.Service
{

    /// <summary>
    /// The service's entry point.
    /// </summary>
    public static class Program
    {

        #region Methods

        /// <summary>
        /// The service's entry point.
        /// </summary>
        /// <param name="args">
        /// Command-line arguments.
        /// </param>
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args)
                   .ConfigureAppConfiguration((hostingContext, configuration) =>
                   {
                       switch (hostingContext.HostingEnvironment.EnvironmentName)
                       {
                           case "Local":
                           case "Development":
                           case "QA":
                           case "Stage":
                           case "Production":
                               configuration.AddJsonFile(Path.Combine(AppContext.BaseDirectory, "Configuration", $"Settings.{hostingContext.HostingEnvironment.EnvironmentName}.json"), true, true);
                               break;
                           default:
                               throw new ArgumentException("Invalid Environment");
                       }
                   })
                   .ConfigureLogging((hostingContext, logging) =>
                   {
                       logging.AddConsole();
                       logging.AddDebug();
                   })
                   .UseStartup<Startup>()
                   .Build()
                   .Run();
        }

        #endregion

    }

}