namespace vAggregator.Shell.Data.Interfaces
{
    /// <summary>
    /// This interface describes the default accessor.
    /// </summary>
    public interface IDefaultAccessor<TModel> where TModel : class
    {
        /// <summary>
        /// This method gets the model by identifier of corresponding entity.
        /// </summary>
        /// <param name="id">Identifier of entity.</param>
        /// <returns>Requested model or exception in case of unexisting identifier.</returns>
        TModel GetById(int id);
    }
}
