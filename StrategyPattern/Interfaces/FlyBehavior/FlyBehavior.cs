using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.FlyBehavior
{
    internal interface FlyBehavior
    {
        public void Fly();
    }
    internal class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }
    internal class FlyNoWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't Fly");
        }
    }
}
