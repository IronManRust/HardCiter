using System;
using System.Collections.Generic;

namespace HardCiter.Domain.Interfaces
{

    public interface IRule<T> where T : class
    {

        #region Methods

        T ProcessAndValidate(T instance, out List<Exception> exceptions, out bool shouldSuppressProcessing);

        #endregion

    }

}