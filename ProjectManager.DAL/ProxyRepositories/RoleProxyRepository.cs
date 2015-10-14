using ProjectManager.Common.DAL;
using ProjectManager.Common.DAL.Repositories;
using ProjectManager.DAL.ProxyRepositories;
using ProjectManager.Entity;

namespace ProjectManager.DAL.Repositories
{
    public class RoleProxyRepository : GenericProxyRepository<ApplicationRole>, IRoleRepository
    {
        public RoleProxyRepository(IGenericRepository<ApplicationRole> context) : base(context) { }
    }
}
