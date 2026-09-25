namespace FacadePattern
{
    internal class DvdPlayer
    {
        private Amplifier _amplifier;

        public DvdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("DVD speler aan");
        }

        public void Off()
        {
            Console.WriteLine("DVD speler uit.");
        }

        public void Eject()
        {
            Console.WriteLine("DVD uitgeworpen");
        }

        public void Pause()
        {
            Console.WriteLine("DVD gepauzeerd");
        }

        public void Play(string movie)
        {
            Console.WriteLine($"Film: {movie}");
        }

        public void SetSurroundAudio()
        {
            Console.WriteLine("Surround audio ingesteld");
        }

        public void SetTWoChannelAudio()
        {
            Console.WriteLine("Two-channel audio ingesteld");
        }

        public void Stop()
        {
            Console.WriteLine("DVD gestopt");
        }
    }
}