using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.UserStorageSystem
{
    public interface IUserAuthorizationService
    {
        public string? Authorize(string username, string password);

        public bool CheckRegistration(string nickName);
    }
}
