using System;
using vAggregator.Shell.Common.Models;

namespace vAggregator.Shell.Data.Adapters
{
    /// <summary>
    /// Represents the adapter is used to adapt users into user models.
    /// </summary>
    internal class UsersAdapter : Adapter<User, UserModel>
    {
        public override UserModel Adapt(User source)
        {
            throw new NotImplementedException();
        }
    }
}
