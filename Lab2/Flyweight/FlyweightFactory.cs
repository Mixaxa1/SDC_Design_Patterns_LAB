using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, EnemyFlyweight> _enemyFlyweights = new Dictionary<string, EnemyFlyweight>();

        public FlyweightFactory(params EnemyFlyweight[] args)
        {
            foreach (var enemyFlyweight in args)
            {
                CreateNewFlyweight(enemyFlyweight);
            }
        }

        public EnemyFlyweight? GetFlyweight(string name)
        {
            if (_enemyFlyweights.ContainsKey(name))
            {
                return _enemyFlyweights[name];
            }
            else
            {
                Console.WriteLine("Enemy not found, create new one");
                return null;
            }
        }

        public void CreateNewFlyweight(EnemyFlyweight flyweight)
        {
            _enemyFlyweights.Add(flyweight.Name, flyweight);
        }

        public void ListFlyweights()
        {
            foreach (var flyweight in _enemyFlyweights)
            {
                Console.WriteLine(flyweight.Key);
            }
        }
    }
}
