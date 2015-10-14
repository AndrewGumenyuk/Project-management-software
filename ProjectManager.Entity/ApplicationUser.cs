using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Entity
{
    public class ApplicationUser : Abstract.Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string PassHash { get; set; }
        public virtual ICollection<ApplicationRole> Roles { get; set; }

        public ApplicationUser()
        {
            Id = Guid.NewGuid();

            Roles = new List<ApplicationRole>();
        }
    }
}
