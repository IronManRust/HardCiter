using System;
using System.Collections.Generic;

namespace HardCiter.Service.Attributes
{

    /// <summary>
    /// Defines valid content types.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class SwaggerConsumesAttribute : Attribute
    {

        #region Constructors

        /// <summary>
        /// Initializes the object that defines valid content types.
        /// </summary>
        /// <param name="contentTypes">
        /// Valid content types.
        /// </param>
        public SwaggerConsumesAttribute(params string[] contentTypes)
        {
            ContentTypes = contentTypes;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Valid content types.
        /// </summary>
        /// <value>
        /// Valid content types.
        /// </value>
        public IEnumerable<string> ContentTypes { get; private set; }

        #endregion

    }

}