using vAggregator.Shell.Data.Accessors;
using vAggregator.Shell.Data.Adapters;
using vAggregator.Shell.Data.Interfaces;

namespace vAggregator.Shell.Data.Creators
{
    public class AccessorCreator
    {
        public IUsersAccessor CreateUsersAccessor()
        {
            var adapter = new UsersAdapter();
            return new UsersAccessor(adapter);
        }
    }
}
