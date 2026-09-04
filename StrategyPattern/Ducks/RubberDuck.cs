using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehavior = new SqueakQuack();
            flyBehavior = new FlyNoWings();
            swimBehavior = new Swim();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck");
        }
    }
}
