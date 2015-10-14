using ProjectManager.Common.DAL;
using ProjectManager.Common.DAL.Repositories;
using ProjectManager.DAL.ProxyRepositories;
using ProjectManager.Entity;

namespace ProjectManager.DAL.Repositories
{
    public class UserProxyRepository : GenericProxyRepository<ApplicationUser>, IUserRepository
    {
        public UserProxyRepository(IGenericRepository<ApplicationUser> context) : base(context) { }
    }
}
