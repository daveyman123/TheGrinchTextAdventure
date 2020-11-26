using System;
using System.Collections.Generic;
using System.Text;

namespace TheGrinch.Scenes
{
    class NorthPole : Scene
    {
        public NorthPole(Game game) : base(game)
        {


            

        }

        public override void Run()
        {
            string[] options = new string[] { "Go to Santa's Workshop", "the Reindeer Stable", "leave the North Pole", "Exit Game" };
            string northPoleArt = Art.Reindeer();
            HelperFunctions.OptionsHelper Opt_Helper = new HelperFunctions.OptionsHelper(northPoleArt, options);
            int Choice = Opt_Helper.MenuChoice();
            switch (Choice)
            {
                case 1:
                    //go to santa's workshop
                    return;
                case 2:
                    // go to stable
                    return;
                case 3:
                    myGame.myMainAreaScene.Run();
                    return;

            }
        }
    }
}
