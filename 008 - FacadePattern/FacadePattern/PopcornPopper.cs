namespace FacadePattern
{
    internal class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("Popcorn machine aan");
        }

        public void Off()
        {
            Console.WriteLine("Popcorn machine uit");
        }

        public void Pop()
        {
            Console.WriteLine("Popcorn word gemaakt");
        }
    }
}