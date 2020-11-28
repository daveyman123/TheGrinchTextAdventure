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
            string mainArt = Art.Train();
            
            Opt_Helper = new OptionsHelper(mainArt);
        }


        public override void Run()
        {
            Console.WriteLine("The train pulls up and passengers scramble to disembark and board.");

            int Choice = Opt_Helper.MenuChoice();

            switch (Choice)
            {
                case 1:
                    //go to north pole
                    myGame.myNorthPoleScene.Run();
                    return;
                case 2:
                    //go to grinch's mansion
                    return;
                case 3:
                    //go to Main street
                    return;
                case 4:
                    myGame.myInventoryScene.Run();
                    return;
                case 5:
                    //System.Threading.Thread.Sleep(100);
                    if (ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else { myGame.myMainAreaScene.Run(); }
                    return;
            }
        }
    }
}
