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

            string[] options = new string[] { "Go to Santa's Workshop", "the Reindeer Stable", "open the Mail Box", "leave the North Pole","View INVENTORY", "Exit Game" };
            string northPoleArt = Art.MailBox();
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
