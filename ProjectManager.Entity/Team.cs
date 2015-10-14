using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Entity
{
    public class Team : Abstract.Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }

        public Team()
        {
            Id = Guid.NewGuid();

            Users = new List<ApplicationUser>();
        }
    }
}
