using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BookStorageSystem
{
    public interface IBookStorage
    {
        public Book? GetBook(string name, string authNick = "");
    }
}
