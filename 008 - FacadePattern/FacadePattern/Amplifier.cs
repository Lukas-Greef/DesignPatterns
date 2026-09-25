namespace FacadePattern
{
    internal class Amplifier
    {
        private Tuner _tuner;
        private DvdPlayer _dvdPlayer;
        private CdPlayer _cdPlayer;

        public void On()
        {
            Console.WriteLine("Amplifier aan");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier uit");
        }

        public void SetCd(CdPlayer cdPlayer)
        {
            this._cdPlayer = cdPlayer;
            Console.WriteLine("CD speler ingesteld");
        }

        public void SetDvd(DvdPlayer dvdPlayer)
        {
            this._dvdPlayer = dvdPlayer;
            Console.WriteLine("Dvd speler ingesteld");
        }

        public void SetStereoSound()
        {
            Console.WriteLine("Stereo geluid ingesteld");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Surround geluid ingesteld");
        }

        public void SetTuner(Tuner tuner)
        {
            this._tuner = tuner;
            Console.WriteLine("Tuner ingesteld");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Volume ingesteld op {volume}");
        }
    }
}