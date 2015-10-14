using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Entity
{
    public class Project : Abstract.Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ApplicationUser ProjectManager { get; set; }
        public ApplicationUser Lead { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }

        public virtual ICollection<Issue> Issues { get; set; }
        public virtual ICollection<Sprint> Sprints { get; set; }

        public Project()
        {
            Id = Guid.NewGuid();

            Users = new List<ApplicationUser>();
            
            Issues = new List<Issue>();
            Sprints = new List<Sprint>();
        }
    }
}
