using System.Collections.Generic;
using vAggregator.Shell.Data.Entities;

namespace vAggregator.Shell.Data.Adapters
{
    internal abstract class Adapter<TSource, TTarget> where TSource : IEntity where TTarget : class
    {
        public abstract TTarget Adapt(TSource source);

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
