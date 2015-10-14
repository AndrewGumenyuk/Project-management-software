using ProjectManager.Common.DAL;
using ProjectManager.Common.DAL.Repositories;
using ProjectManager.DAL.ProxyRepositories;
using ProjectManager.Entity;

namespace ProjectManager.DAL.Repositories
{
    public class IssueProxyRepository : GenericProxyRepository<Issue>, IIssueRepository
    {
        public IssueProxyRepository(IGenericRepository<Issue> context) : base(context) { }
    }
}
