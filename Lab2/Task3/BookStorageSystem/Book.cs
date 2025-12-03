using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BookStorageSystem
{
    public class Book
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Title + " - " + Description;
        }
    }
}
