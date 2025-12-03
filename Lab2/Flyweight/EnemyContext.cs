using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class EnemyContext
    {
        private readonly EnemyFlyweight _flyweight;

        public int Dmg;
        public int Def;

        public EnemyContext(EnemyFlyweight flyweight)
        {
            _flyweight = flyweight;
        }

        public void Attack()
        {
            Console.WriteLine($"{_flyweight.Name} attaks and deals {Dmg} damage");
            _flyweight.Attack();
        }

        public void GetHit(int recivedDmg)
        {
            Console.WriteLine($"{_flyweight.Name} gets {recivedDmg - Def} damage");
            _flyweight.GetHit();
        }
    }
}
