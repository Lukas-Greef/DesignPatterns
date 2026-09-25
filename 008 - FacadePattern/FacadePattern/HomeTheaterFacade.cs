namespace FacadePattern
{
	internal class HomeTheaterFacade
	{
		private Amplifier _amp;
		private CdPlayer _cdPlayer;
		private DvdPlayer _dvdPlayer;
		private PopcornPopper _popcornPopper;
		private Projector _projector;
		private Screen _screen;
		private TheaterLights _lights;
		private Tuner _tuner;

		public HomeTheaterFacade(
			Amplifier amp,
			CdPlayer cdPlayer,
			DvdPlayer dvdPlayer,
			PopcornPopper popcornPopper,
			Projector projector,
			Screen screen,
			TheaterLights lights,
			Tuner tuner)
		{
			_amp = amp;
			_cdPlayer = cdPlayer;
			_dvdPlayer = dvdPlayer;
			_popcornPopper = popcornPopper;
			_projector = projector;
			_screen = screen;
			_lights = lights;
			_tuner = tuner;
		}

		public void WatchMovie(string movie)
		{
			Console.WriteLine("Film starten...");
			Console.WriteLine();

			_popcornPopper.On();
			_popcornPopper.Pop();

			_lights.Dim(10);

			_screen.Down();

			_projector.On();
			_projector.SetInput(_dvdPlayer);
			_projector.WideScreenMode();

			_amp.On();
			_amp.SetDvd(_dvdPlayer);
			_amp.SetSurroundSound();
			_amp.SetVolume(5);

			_dvdPlayer.On();
			_dvdPlayer.Play(movie);

			Console.WriteLine();
			Console.WriteLine("Film speelt nu af.");
		}

		public void EndMovie()
		{
			Console.WriteLine();
			Console.WriteLine("Film stoppen...");
			Console.WriteLine();

			_dvdPlayer.Stop();
			_dvdPlayer.Eject();
			_dvdPlayer.Off();

			_amp.Off();

			_projector.Off();

			_lights.On();

			_screen.Up();

			_popcornPopper.Off();

			Console.WriteLine();
			Console.WriteLine("Film gestopt.");
		}
	}
}