using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Entity
{
    public class Sprint : Abstract.Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Project Project { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }

        public virtual ICollection<Issue> Issues { get; set; }

        public Sprint()
        {
            Id = Guid.NewGuid();

            Issues = new List<Issue>();
        }
    }
}
