using System;
using vAggregator.Shell.Data.Interfaces;

namespace vAggregator.Shell.Data.Accessors
{
    /// <summary>
    /// This class represents the default accessor.
    /// </summary>
    internal class DefaultAccessor<TModel> : IDefaultAccessor<TModel> where TModel : class
    {
        /// <summary>
        /// This method gets the model by identifier of corresponding entity.
        /// </summary>
        /// <param name="id">Identifier of entity.</param>
        /// <returns>Requested model or exception in case of unexisting identifier.</returns>
        public virtual TModel GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
