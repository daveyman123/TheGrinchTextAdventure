using System;
using System.Collections.Generic;
using System.Text;

namespace TheGrinch.Scenes
{
    class CreditsScene : Scene
    {
        public CreditsScene(Game game) : base(game)
        {

        }
        public override void Run() {
            Console.WriteLine("Thanks for playing The Grinch!\n" +
                Art.Ham()
                + "\n");
            Console.WriteLine("https://ascii.co.uk/art/reindeer");
            Console.WriteLine("https://www.asciiart.eu/");
            Console.WriteLine("Snowdrift Waltz” by Naoshi Mizuta from Final Fantasy XI: Wings of the Goddess: \n" +
                "https://www.youtube.com/watch?time_continue=21&v=2b-WsCS3Sk4&feature=emb_title");
            Console.WriteLine("https://freesound.org/");
            Console.WriteLine("https://asciiart.website/index.php?art=holiday/christmas/");
            Console.WriteLine("https://www.asciiart.eu/holiday-and-events/christmas/other");
            Console.WriteLine("ascii-art.de/ascii/t/train.txt");
            Console.WriteLine("https://bigsoundbank.com/");
            Console.WriteLine("\nDownload the source Code here: https://github.com/daveyman123/TheGrinchTextAdventure");
            //base always print out inventory possibly
            base.Run();
            Console.ReadLine();
        }
    }
}
