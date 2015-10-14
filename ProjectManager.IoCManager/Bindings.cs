using Ninject.Modules;
using ProjectManager.Common.DAL;
using ProjectManager.Common.DAL.Repositories;
using ProjectManager.DAL;
using ProjectManager.DAL.Repositories;
using ProjectManager.Entity;

namespace ProjectManager.IoCManager
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IAttachmentRepository>().To<AttachmentProxyRepository>();
            Bind<ICommentRepository>().To<CommentProxyRepository>();
            Bind<IComponentRepository>().To<ComponentProxyRepository>();
            Bind<IIssueRepository>().To<IssueProxyRepository>();
            Bind<IProjectRepository>().To<ProjectProxyRepository>();
            Bind<IRoleRepository>().To<RoleProxyRepository>();
            Bind<ISprintRepository>().To<SprintProxyRepository>();
            Bind<ITeamRepository>().To<TeamProxyRepository>();
            Bind<IUserRepository>().To<UserProxyRepository>();

            Bind<IGenericRepository<Attachment>>().To<AttachmentRepository>();
            Bind<IGenericRepository<Comment>>().To<CommentRepository>();
            Bind<IGenericRepository<Component>>().To<ComponentRepository>();
            Bind<IGenericRepository<Issue>>().To<IssueRepository>();
            Bind<IGenericRepository<Project>>().To<ProjectRepository>();
            Bind<IGenericRepository<ApplicationRole>>().To<RoleRepository>();
            Bind<IGenericRepository<Sprint>>().To<SprintRepository>();
            Bind<IGenericRepository<Team>>().To<TeamRepository>();
            Bind<IGenericRepository<ApplicationUser>>().To<UserRepository>();

            Bind<IDataContext>().To<DataContext>().InSingletonScope();
        }
    }
}
