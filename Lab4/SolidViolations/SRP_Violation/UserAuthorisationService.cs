using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidViolations.SRP_Violation
{
    public class UserAuthorisationService
    {
        private List<User> allUsers = new List<User>() 
        {
            new User() { Login = "test1", Password = "pas", AccauntBalance = 356 },
            new User() { Login = "someUser", Password = "querty", AccauntBalance = 761}
        };

        public User? AuthoriseUser(string login, string password)
        {
            var user = allUsers.Find(x => x.Login == login);
            if (user != null && user.Password == password)
            {
                return user;
            }
            return null;
        }

        public bool MakeTransaction(User benefactor, User beneficiar, float amount)
        {
            if (benefactor.AccauntBalance >= amount)
            {
                benefactor.AccauntBalance -= amount;
                beneficiar.AccauntBalance += amount;

                return true;
            }

            return false;
        }
    }
}
