using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.QuackBehavior
{
    internal interface QuackBehavior
    {
        public void Quack();
    }
    internal class RegularQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("quack");
        }
    }
    internal class MuteQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<silence>");
        }
    }
    internal class SqueakQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
