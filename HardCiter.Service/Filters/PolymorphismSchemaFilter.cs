using System;
using System.Collections.Generic;
using System.Linq;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HardCiter.Service.Filters
{

    /// <summary>
    /// Filters Swagger schemas.
    /// </summary>
    public class PolymorphismSchemaFilter : ISchemaFilter
    {

        #region Variables

        private Type _type;

        #endregion

        #region Constructors

        /// <summary>
        /// Applies the associated Swagger filter.
        /// </summary>
        /// <param name="type">
        /// The type to add polymorphism information about.
        /// </param>
        public PolymorphismSchemaFilter(Type type)
        {
            _type = type;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Applies the associated Swagger filter.
        /// </summary>
        /// <param name="schema">
        /// The current schema.
        /// </param>
        /// <param name="context">
        /// The current context.
        /// </param>
        public void Apply(Schema schema, SchemaFilterContext context)
        {
            if (schema != null &&
                context != null &&
                context.SystemType != null &&
                context.SystemType.BaseType == _type)
            {
                schema.AllOf = new List<Schema>()
                {
                    new Schema()
                    {
                        Ref = "#/definitions/" + _type.Name
                    }
                };
            }
        }

        #endregion

    }

}