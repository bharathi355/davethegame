namespace DaveGame
{
    static class EntryPoint
    {
        static void Main()
        {
            var game = new Game();

            if (!Common.IsExeRunning())
                game.Run();
            else
                game.Exit();
        }
    }
}