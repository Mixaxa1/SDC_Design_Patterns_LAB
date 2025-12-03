using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Db.Entities
{
    public interface INeedValidation
    {
        public abstract bool IsValid();
    }
}
