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
            Console.WriteLine("https://ascii.co.uk/art/reindeer");
            Console.WriteLine("Snowdrift Waltz” by Naoshi Mizuta from Final Fantasy XI: Wings of the Goddess: \n" +
                "https://www.youtube.com/watch?time_continue=21&v=2b-WsCS3Sk4&feature=emb_title");
            Console.WriteLine("https://freesound.org/");
            Console.WriteLine("https://asciiart.website/index.php?art=holiday/christmas/snowman");
            //base always print out inventory possibly
            base.Run();
        }
    }
}
