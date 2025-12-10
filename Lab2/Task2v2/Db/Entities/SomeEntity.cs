using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2v2.Db.Entities
{   public class SomeEntity
    {
        public Guid Id { get; set; }
        public EntityStatus Status { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Description} {Status}";
        }
    }
}
