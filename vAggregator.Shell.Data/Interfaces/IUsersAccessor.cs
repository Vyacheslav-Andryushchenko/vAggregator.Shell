using vAggregator.Shell.Common.Models;

namespace vAggregator.Shell.Data.Interfaces
{
    /// <summary>
    /// This interface describes a user accessor.
    /// </summary>
    public interface IUsersAccessor
    {
        /// <summary>
        /// Gets the user by identifier.
        /// </summary>
        /// <param name="userId">Identifier of user.</param>
        /// <returns>User.</returns>
        UserModel GetById(int userId);
    }
}
