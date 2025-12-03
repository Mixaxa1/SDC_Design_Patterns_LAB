using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Db.Entities
{   public class SomeEntity : INeedValidation
    {
        public int Id { get; set; }
        public EntityStatus Status { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Description} {Status}";
        }

        public virtual bool IsValid()
        {
            return Name != string.Empty && Description != string.Empty;
        }
    }
}
