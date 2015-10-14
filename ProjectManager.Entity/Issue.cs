using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManager.Entity.Enumerations;

namespace ProjectManager.Entity
{
    public class Issue : Abstract.Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Environment { get; set; }

        public Project Project { get; set; }
        public Sprint Sprint { get; set; }

        public ApplicationUser Assigne { get; set; }
        public ApplicationUser Reporter { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public IssueType Type { get; set; }
        public IssueStatus Status { get; set; }
        public IssuePriority Priority { get; set; }

        public Issue Parent { get; set; }
        public virtual ICollection<Issue> Children { get; set; }
        public bool HasChild
        {
            get { return Children.Count != 0; }
        }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Component> Components { get; set; }

        public Issue()
        {
            Id = Guid.NewGuid();

            Created = DateTime.Now;
            Updated = DateTime.Now;

            Children = new List<Issue>();
            Comments = new List<Comment>();
            Components = new List<Component>();
        }
    }
}
