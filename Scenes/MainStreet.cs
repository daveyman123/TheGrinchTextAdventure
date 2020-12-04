using System;
using System.Collections.Generic;
using System.Text;
using TheGrinch.HelperFunctions;
namespace TheGrinch.Scenes
{
    class MainStreet : Scene
    {
        int Choice;
        string addText;
        public MainStreet(Game game) : base(game)
        {
            addText = "";
 
        }

        public override void Run()
        {
            text = "Welcome to the Main Street! The weather is cold and houses are decorated for the season.\n" + Art.MainStreet() + "\n" + addText;

            AddScene(this.GetType().Name);

            options = new string[]{ "Go to Suzy's house", "Go to Bobby's house", "Leave Main Street", "View INVENTORY", "Exit Game"};
            base.Run();
            //Choice = opt_helper.MenuChoice();
            switch(optionsChoice)
            {
                case 1:
                    //go to susys house
                    if (myGame.myInventory.Contains("Elf Hat"))
                    {
                        addText = "";
                        myGame.mySuzysHouseScene.Run();

                    }
                    else
                    {
                        addText = "\n" + "You need to be an elf to enter houses on main street!";
                        myGame.myMainStreetScene.Run();

                    }
                    return;
                case 2:
                    // go to bobby's house
                    if (myGame.myInventory.Contains("Elf Hat"))
                    {
                        addText = "";
                        myGame.myBobbysHouseScene.Run();
                        
                    }
                    else
                    {
                        addText = "\n"+ "You need to be an elf to enter houses on main street!";
                        myGame.myMainStreetScene.Run();
                      
                    }
                    
                    return;
                case 3:
                    addText = "";
                    myGame.myMainAreaScene.Run();
                    return;
                case 4:
                    addText = "";
                    myGame.myInventoryScene.Run();
                    return;
                case 5:
                    if (ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else { myGame.myMainStreetScene.Run(); }
                    return;
            }
        }
    }
}
