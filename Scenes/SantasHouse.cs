using System;
using System.Collections.Generic;
using System.Text;
using TheGrinch.HelperFunctions;
namespace TheGrinch.Scenes
{
    class SantasHouse : Scene
    {
        public string addText;
        public SantasHouse(Game game) : base(game)
        {

            myGame = game;
           

        }

        public override void Run()
        {
            
            Scene.AddScene(this.GetType().Name);

            options = new string[] { "Ask why Santa is in a hurry", "Ask what you can do to help with Christmas", "Leave Santa's House", "View INVENTORY", "Exit Game" };
            string northPoleArt = Art.Santa(); ;
            text = "Santa greets you at the door, he seems to be in a hurry!\n " + northPoleArt + "\n" + addText;
            base.Run();
            switch (optionsChoice)
            {
                case 1:
                    addText = "Santa responds that 'he is in a hurry because this year there is a lot of trouble.\n" +
                        "The Grinch has taken extra measures to destroy the christmas spirit by stealing presents\n" +
                        "namely on Main Street!'\n" +
                        "Santa tugs his sack to rest it more firmly on his shoulder. \n'As you may have seen from letters sent to the North Pole, there are distraught\n" +
                        "children on mainstreet it seems the grinch is messing with MY delivery system and now there is confusion throughout the Elf delivery \n fleet! time is running out\n" +
                        "and I am in need of a CHRISTMAS MIRACLE ";
                    myGame.mySantaScene.Run();
                    return;
                case 2:
                    addText =
                         myGame.GetName() + ",you, can actually help by taking gifts, found in the workshop, to the proper addresses \n" +
                        "or *heaven forbid*, you could go to the grinch's mansion to comfront that PORCH THIEFING Basterd yourself!\n" +
                        "Go now, leave me.";

                   
                    myGame.mySantaScene.Run();
                    return;
                case 3:
                    //open mailbox
                    
                    myGame.myNorthPoleScene.Run();
                    return;
                case 4:
                    if (ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else { myGame.myMainAreaScene.Run(); }
                    return;


            }
        }
    }
}
