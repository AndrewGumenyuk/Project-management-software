using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Entity
{
    public class Component : Abstract.Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Issue> Issues { get; set; }

        public Component()
        {
            Id = Guid.NewGuid();

            Issues = new List<Issue>();
        }
    }
}
