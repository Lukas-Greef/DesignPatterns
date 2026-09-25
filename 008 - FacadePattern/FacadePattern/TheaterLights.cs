namespace FacadePattern
{
    internal class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Theaterverlichting aan");
        }

        public void Off()
        {
            Console.WriteLine("Theaterverlichting uit");
        }

        public void Dim(int value)
        {
            Console.WriteLine("Theaterverlichting gedimd naar {value}");
        }
    }
}