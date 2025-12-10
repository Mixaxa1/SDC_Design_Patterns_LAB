using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3v2ApiSide.ApiSide.UserAuthorizationSystem
{
    public interface IUserAuthorizationService
    {
        public string? Authorize(string username, string password);

        public bool CheckRegistration(string nickName);
    }
}
