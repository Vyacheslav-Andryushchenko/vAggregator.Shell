using System;
using vAggregator.Shell.Common.Models;

namespace vAggregator.Shell.Data.Adapters
{
    internal class UsersAdapter : Adapter<User, UserModel>
    {
        public override UserModel Adapt(User source)
        {
            throw new NotImplementedException();
        }
    }
}
