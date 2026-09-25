namespace FacadePattern
{
    internal class Tuner
    {
        private Amplifier _amplifier;

        public Tuner(Amplifier amplifier)
        {
            this._amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("Tuner aan");
        }

        public void Off()
        {
            Console.WriteLine("Tuner uit");
        }

        public void setAM()
        {
            Console.WriteLine("AM ingesteld");
        }

        public void setFM()
        {
            Console.WriteLine("FM ingesteld");
        }

        public void setFrequency()
        {
            Console.WriteLine("Frequentie ingesteld");
        }
    }
}