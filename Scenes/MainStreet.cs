using System;
using System.Collections.Generic;
using System.Text;
using TheGrinch.HelperFunctions;
namespace TheGrinch.Scenes
{
    class MainStreet : Scene
    {
        int Choice;
        public MainStreet(Game game) : base(game)
        {

        }

        public override void Run()
        {
            AddScene(this.GetType().Name);

            text = Art.MainStreet() + "\n Welcome to the Main Street!";
            options = new string[]{ "go to Suzy's house", "go to Bobby's house", "leave Main Street", "View INVENTORY", "Exit Game"};
            base.Run();
            //Choice = opt_helper.MenuChoice();
            switch(optionsChoice)
            {
                case 1:
                    //go to susys house
                    return;
                case 2:
                    // go to bobby's house
                    myGame.myBobbysHouseScene.Run();
                    return;
                case 3:
                    myGame.myMainAreaScene.Run();
                    return;
                case 4:
                    myGame.myInventoryScene.Run();
                    return;
                case 5:
                    if (ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else { myGame.myMainStreetScene.Run(); }
                    return;
            }
        }
    }
}
