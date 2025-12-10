using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3v2ApiSide.ApiSide.PermitionsStorageSystem
{
    public interface IPermitionStorage
    {
        public bool CheckPermition(string user, string book);
    }
}
