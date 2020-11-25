using System;
using static System.Console;
using System.Text;
using TheGrinch.HelperFunctions;
namespace TheGrinch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WindowWidth = 130;
                WindowHeight = 35;
            }
            catch
            {
                Console.WriteLine("Cannot create a big enough console window");
                Console.WriteLine("Try adjusting your font/console settings and restarting.");
                Console.WriteLine("You can continue playing, just be aware that some art might not render properly!");
                Console.ReadLine();
            }
           
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Blue;

            //try to start game
            while (Game.getPlay())
            {
                Game myGame = new Game();
                myGame.Start();
            }
            ConsoleUtils.QuitConsole();
        }
    }
}
