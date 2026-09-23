namespace GameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameFacade game = new GameFacade();

            Console.WriteLine("Kies een mode:");
            Console.WriteLine("1 = Normal Mode");
            Console.WriteLine("2 = Developer Mode");

            string modeChoice = Console.ReadLine();

            bool developerMode = modeChoice == "2";

            Console.WriteLine();
            Console.WriteLine("Kies een game-modus:");
            Console.WriteLine("1 = Online");
            Console.WriteLine("2 = Offline");

            string onlineChoice = Console.ReadLine();

            bool online = onlineChoice == "1";

            Console.WriteLine();

            game.StartGame(developerMode, online);

            Console.WriteLine();
            Console.WriteLine("Druk op enter om de game te stoppen.");
            Console.ReadLine();

            game.StopGame();

            Console.WriteLine();
            Console.WriteLine("Druk op enter om af te sluiten.");
            Console.ReadLine();
        }
    }
}