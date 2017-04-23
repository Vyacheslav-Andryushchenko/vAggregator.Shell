using System;
using vAggregator.Shell.Common.Models;
using vAggregator.Shell.Data.Interfaces;

namespace vAggregator.Shell.Data.Implementation
{
    /// <summary>
    /// This class implements a user accessor.
    /// </summary>
    internal class UsersAccessor : IUsersAccessor
    {
        /// <inheritdoc/>
        public UserModel GetById(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
