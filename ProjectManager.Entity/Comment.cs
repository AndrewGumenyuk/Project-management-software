using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Entity
{
    public class Comment : Abstract.Entity
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public ApplicationUser Author { get; set; }
        public Issue Issue { get; set; }

        public Comment()
        {
            Id = Guid.NewGuid();
        }
    }
}
