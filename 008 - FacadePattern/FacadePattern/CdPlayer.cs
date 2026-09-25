using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class CdPlayer
    {
        private Amplifier _amplifier;
        public CdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("Cd speler aan");
        }

        public void Off()
        {
            Console.WriteLine("Cd speler uit");
        }

        public void Eject()
        {
            Console.WriteLine("Cd uitgeworpen");
        }

        public void Pause()
        {
            Console.WriteLine("Cd gepauzeerd");
        }

        public void Play(string movie)
        {
            Console.WriteLine($"Film: {movie}");
        }

        public void Stop()
        {
            Console.WriteLine("Cd gestopt");
        }
    }
}
