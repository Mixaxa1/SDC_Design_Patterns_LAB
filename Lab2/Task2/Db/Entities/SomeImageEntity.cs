using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Db.Entities
{
    [NotMapped]
    public class SomeImageEntity : SomeEntity
    {
        public string ImageUrl { get; set; }

        public override bool IsValid()
        {
            return base.IsValid() && ImageUrl != string.Empty;
        }

        public override string ToString()
        {
            return base.ToString() + $" {ImageUrl}";
        }
    }
}
