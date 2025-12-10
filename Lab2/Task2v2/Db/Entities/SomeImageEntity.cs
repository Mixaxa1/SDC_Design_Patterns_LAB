using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2v2.Db.Entities
{   public class SomeImageEntity
    {
        public Guid Id { get; set; }
        public Guid SomeEntityId { get; set; }
        public SomeEntity SomeEntity { get; set; }
        public string ImageUrl { get; set; }
    }
}
