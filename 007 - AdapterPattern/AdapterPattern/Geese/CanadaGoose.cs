using AdapterPattern.Interfaces;
using System;

namespace AdapterPattern.Gooses
{
    internal class CanadaGoose : Goose
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying like a goose");
        }

        public void Honk()
        {
            Console.WriteLine("Honk honk");
        }
    }
}