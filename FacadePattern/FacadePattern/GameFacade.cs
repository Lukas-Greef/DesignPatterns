namespace GameApp
{
    public class GameFacade
    {
        private GraphicsSystem graphics;
        private AudioSystem audio;
        private SaveSystem saveSystem;
        private NetworkService network;
        private GameEngine gameEngine;
        private InputSystem input;
        private ResourceSystem resources;

        public GameFacade()
        {
            graphics = new GraphicsSystem();
            audio = new AudioSystem();
            saveSystem = new SaveSystem();
            network = new NetworkService();
            gameEngine = new GameEngine();
            input = new InputSystem();
            resources = new ResourceSystem();
        }

        public void StartGame(bool developerMode, bool online)
        {
            Console.WriteLine("Game wordt gestart...");

            graphics.Initialize();

            if (developerMode)
            {
                graphics.SetResolution(2560, 1440);
                audio.Initialize();
                audio.SetVolume(100);
                Console.WriteLine("Developer mode gestart.");
            }
            else
            {
                graphics.SetResolution(1920, 1080);
                audio.Initialize();
                audio.SetVolume(70);
                Console.WriteLine("normal mode gestart.");
            }

            saveSystem.LoadSettings();
            saveSystem.LoadPlayer();

            if (online)
            {
                network.Connect();
                network.Login();
            }
            else
            {
                Console.WriteLine("offline modus actief.");
            }

            gameEngine.LoadWorld();
            gameEngine.Start();

            Console.WriteLine("Game is gestart.");
        }

        public void StopGame()
        {
            Console.WriteLine();
            Console.WriteLine("Game wordt gestopt...");

            input.StopInput();
            resources.ReleaseResources();

            Console.WriteLine("Game gestopt.");
        }
    }
}
