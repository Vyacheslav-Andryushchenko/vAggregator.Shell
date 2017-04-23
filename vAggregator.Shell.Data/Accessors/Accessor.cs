using System;
using vAggregator.Shell.Data.Adapters;
using vAggregator.Shell.Data.Entities;
using vAggregator.Shell.Data.Interfaces;

namespace vAggregator.Shell.Data.Accessors
{
    /// <summary>
    /// Represents the accessor.
    /// </summary>
    internal class Accessor<TModel, TEntity> : IDefaultAccessor<TModel> 
        where TModel : class 
        where TEntity : IEntity
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="adapter">Adapter to adapt entities into models.</param>
        protected Accessor(Adapter<TEntity, TModel> adapter)
        {
            this.Adapter = adapter;
        }

        /// <summary>
        /// Adapter to adapt entities into models.
        /// </summary>
        protected Adapter<TEntity, TModel> Adapter;    

        /// <summary>
        /// Gets the model by identifier of corresponding entity.
        /// </summary>
        /// <param name="id">Identifier of entity.</param>
        /// <returns>Requested model or exception in case of unexisting identifier.</returns>
        public virtual TModel GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
