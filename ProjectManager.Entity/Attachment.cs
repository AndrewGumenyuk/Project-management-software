using System;

namespace ProjectManager.Entity
{
    public class Attachment : Abstract.Entity
    {
        public Attachment()
        {
            Id = Guid.NewGuid();
        }


        public string Name { get; set; }
        public string Uri { get; set; }

        public Issue Issue { get; set; }
    }
}
