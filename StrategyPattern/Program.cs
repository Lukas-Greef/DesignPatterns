using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformQuack();
            mallard.PerformFly();

            Console.WriteLine();

            Duck redheadDuck = new RedheadDuck();
            redheadDuck.Display();
            redheadDuck.PerformQuack();
            redheadDuck.PerformFly();

            Console.WriteLine();

            Duck decoyDuck = new DecoyDuck();
            decoyDuck.Display();
            decoyDuck.PerformSwim();

            Console.WriteLine();

            Duck rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.PerformSwim();

            Console.WriteLine();

            Duck robotDuck = new RobotDuck();
            robotDuck.Display();
            robotDuck.PerformSwim();

            Console.WriteLine();
        }
    }
}