using System;
using System.Collections.Generic;
using System.Text;
using TheGrinch.HelperFunctions;
namespace TheGrinch.Scenes
{
    class NorthPole : Scene
    {
        public NorthPole(Game game) : base(game)
        {


           

        }

        public override void Run()
        {
            Scene.AddScene(this.GetType().Name);

            string[] options = new string[] { "Go to Santa's Workshop", "Go to Santa's House", "Open the Mail Box", "Leave the North Pole","View INVENTORY", "Exit Game" };
            string northPoleArt = "It's cold here and the mood is somber, Given all the distressful letters in the mailbox.\n" + Art.MailBox();
            HelperFunctions.OptionsHelper Opt_Helper = new HelperFunctions.OptionsHelper(northPoleArt, options);
            int Choice = Opt_Helper.MenuChoice();
            switch (Choice)
            {
                case 1:
                    myGame.myWorkshopScene.Run();
                    return;
                case 2:
                    myGame.mySantaScene.Run();
                    return;
                case 3:
                    //open mailbox
                    
                    myGame.myReadLetterScene.Run();
                    return;
                case 4:
                    myGame.myMainAreaScene.Run();
                    return;
                case 5:
                    myGame.myInventoryScene.Run();
                    return;
                case 6:
                    if (ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else { myGame.myMainAreaScene.Run(); }
                    return;


            }
        }
    }
}
