using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.SwimBehavior
{
    internal interface SwimBehavior
    {
        public void Swim();
    }
    internal class Swim : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("Swim");
        }
    }
    internal class NoSwim : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("Sink");
        }
    }
}
