using System;
using System.Collections.Generic;
using System.Text;
using TheGrinch.HelperFunctions;

namespace TheGrinch.Scenes
{
    class MainArea : Scene
    {
        OptionsHelper Opt_Helper;
        public MainArea(Game game) : base(game)
        {
            string mainArt = Art.Main();
            
            Opt_Helper = new OptionsHelper(mainArt);
        }


        public override void Run()
        {
            int Choice = Opt_Helper.MenuChoice();

            switch (Choice)
            {
                case 1:
                    //go to north pole
                    return;
                case 2:
                    //go to grinch's mansion
                    return;
                case 3:
                    //go to the park
                    return;
                case 4:
                    if (ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else myGame.myMainAreaScene.Run();
                    return;
            }
        }
    }
}
