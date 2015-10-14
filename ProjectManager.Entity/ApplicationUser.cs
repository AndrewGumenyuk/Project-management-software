using System;
using System.Collections.Generic;

namespace ProjectManager.Entity
{
    public class ApplicationUser : Abstract.Entity
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();

            Roles = new List<ApplicationRole>();
        }


        public string Name { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string PassHash { get; set; }
        public virtual ICollection<ApplicationRole> Roles { get; set; }
    }
}
