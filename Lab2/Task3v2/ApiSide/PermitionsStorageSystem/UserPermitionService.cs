using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3v2ApiSide.ApiSide.PermitionsStorageSystem
{
    public class PermitionStorage : IPermitionStorage
    {
        private Dictionary<string, List<string>> _permitions = new Dictionary<string, List<string>>();

        public PermitionStorage()
        {
            Initialize();
        }

        public void Initialize()
        {
            _permitions.Clear();

            var permitions = new List<(string, List<string>)>()
            {
                ("Paranoid", new List<string>() { "Jaba", "Test1" }),
                ("Mester", new List<string>() { "AbsoluteBook", "Jaba" })
            };

            foreach (var perm in permitions)
            {
                _permitions.Add(perm.Item1, perm.Item2);
            }
        }

        public bool CheckPermition(string user, string book)
        {
            if (_permitions.ContainsKey(user))
            {
                if (_permitions[user].Contains(book))
                {
                    return true;
                }
            }

            return false;
        } 
    }
}
