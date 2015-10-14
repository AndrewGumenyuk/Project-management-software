using System;
using System.Collections.Generic;

namespace ProjectManager.Entity
{
    public class ApplicationRole : Abstract.Entity
    {
        public ApplicationRole()
        {
            Id = Guid.NewGuid();

            Users = new List<ApplicationUser>();
        }


        public string Name { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}
