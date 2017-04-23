using System.Collections.Generic;
using vAggregator.Shell.Data.Entities;

namespace vAggregator.Shell.Data.Adapters
{
    /// <summary>
    /// Represents the adapter is used to adapt entities into models.
    /// </summary>
    /// <typeparam name="TSource">Entity type.</typeparam>
    /// <typeparam name="TTarget">Model type.</typeparam>
    /// <remarks>
    /// The class is used to preventing cross-layer interaction
    /// with entities which located in ORM context.
    /// </remarks>
    internal abstract class Adapter<TSource, TTarget> where TSource : IEntity where TTarget : class
    {
        /// <summary>
        /// Adapts entity into model.
        /// </summary>
        /// <param name="source">Entity.</param>
        /// <returns>Model.</returns>
        public abstract TTarget Adapt(TSource source);

        /// <summary>
        /// Adapts enumeration of entities to enumeration of models.
        /// </summary>
        /// <param name="source">Enumeration of entities.</param>
        /// <returns>Enumeration of models.</returns>
        public IEnumerable<TTarget> AdaptRange(IEnumerable<TSource> source)
        {
            var result = new List<TTarget>();

            foreach (var item in source)
            {
                result.Add(this.Adapt(item));
            }

            return result;
        }
    }
}
