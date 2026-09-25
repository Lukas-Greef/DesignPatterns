namespace FacadePattern
{
    internal class Projector
    {
        private DvdPlayer _dvdPlayer;

        public Projector()
        {
        }

        public void SetInput(DvdPlayer dvdPlayer)
        {
            this._dvdPlayer = dvdPlayer;
            Console.WriteLine("Projector ingesteld op DVD");
        }

        public void On()
        {
            Console.WriteLine("Projector aan");
        }

        public void Off()
        {
            Console.WriteLine("Projector uit");
        }

        public void TvMode()
        {
            Console.WriteLine("tvmodus ingesteld");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Breed beeldmodus ingesteld");
        }
    }
}