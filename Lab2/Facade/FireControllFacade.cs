using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.SubSystems;

namespace Facade
{
    public class FireControllFacade
    {
        private RangefinderSubsystem _rangefinder;
        private AimingSubsystem _aiming;
        private ReloadingSubsystem _reloading;
        private Ship _self;

        public bool locked = false;
        public Ship? target;


        public FireControllFacade(RangefinderSubsystem rangefinder, AimingSubsystem aiming, ReloadingSubsystem reloading, Ship self)
        {
            _rangefinder = rangefinder;
            _aiming = aiming;
            _reloading = reloading;
            _self = self;

        }

        public void EngageTarget(Ship targetShip)
        {
            target = targetShip;

            _aiming.AimOnTarget(target.XPos, target.YPos);

            var range = _rangefinder.GetRangeToTarget(target, _self);
            _aiming.SetRange(range);
            
            locked = true;

            ShellTypes shell;
            if (range < 10)
            {
                shell = ShellTypes.HE;
            }
            else if (range < 20)
            {
                shell = ShellTypes.HE_VT;
            }
            else
            {
                shell = ShellTypes.AP;
            }

            _reloading.LoadShell(shell);

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);

                Thread.Sleep(10);
            }
            Console.WriteLine();

            Fire();
        }

        public void Fire()
        {
            if (locked)
            {
                Console.WriteLine("Opening fire on target");

                for (int i =0; i < 10; i++)
                {
                    Console.Write(i);
            
                    Thread.Sleep(10);
                }
                Console.WriteLine();

                target.Hp -= 10;
                Console.WriteLine("Confirm hit on target");

                if (target.Hp <= 0)
                {
                    Console.WriteLine("We sunk them");
                    target = null;
                }

                locked = false;
            }
        }
    }
}
