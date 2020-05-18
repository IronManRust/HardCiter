using System;
using System.Collections.Generic;
using System.Linq;
using HardCiter.Service.Attributes;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HardCiter.Service.Filters
{

    /// <summary>
    /// Filters Swagger operations.
    /// </summary>
    public class SwaggerConsumesFilter : IOperationFilter
    {

        #region Methods

        /// <summary>
        /// Applies the associated Swagger filter.
        /// </summary>
        /// <param name="operation">
        /// The current operation.
        /// </param>
        /// <param name="context">
        /// The current context.
        /// </param>
        public void Apply(Operation operation, OperationFilterContext context)
        {
            List<string> contentTypes = new List<string>();
            if (context != null &&
                context.MethodInfo != null &&
                context.MethodInfo.DeclaringType != null)
            {
                contentTypes.AddRange(context.MethodInfo.DeclaringType.GetCustomAttributes(true)
                                                                      .Union(context.MethodInfo.GetCustomAttributes(true))
                                                                      .OfType<SwaggerConsumesAttribute>()
                                                                      .SelectMany(x => x.ContentTypes)
                                                                      .ToList());
            }
            if (operation != null &&
                contentTypes != null &&
                contentTypes.Any())
            {
                operation.Consumes = contentTypes;
            }
        }

        #endregion

    }

}