using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Entity
{
    public class Attachment : Abstract.Entity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Uri { get; set; }

        public Issue Issue { get; set; }

        public Attachment()
        {
            Id = Guid.NewGuid();
        }
    }
}
