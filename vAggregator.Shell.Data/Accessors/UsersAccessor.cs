using vAggregator.Shell.Common.Models;
using vAggregator.Shell.Data.Adapters;
using vAggregator.Shell.Data.Interfaces;

namespace vAggregator.Shell.Data.Accessors
{
    /// <summary>
    /// This class implements the users accessor.
    /// </summary>
    internal class UsersAccessor : Accessor<UserModel, User>, IUsersAccessor
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="adapter">Adapter to adapt entities into models.</param>
        public UsersAccessor(Adapter<User, UserModel> adapter) : base(adapter)
        {
        }
    }
}
