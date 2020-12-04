using System;
using System.Collections.Generic;
using System.Text;
using TheGrinch.HelperFunctions;
namespace TheGrinch.Scenes
{
    class SantasHouse : Scene
    {
        public string addText;
        Item elfHat;
        string northPoleArt;
        
        public SantasHouse(Game game) : base(game)
        {
            northPoleArt = Art.Santa();
            myGame = game;
            addText = "";
            elfHat = new Item("Elf Hat", "It's a nice hat, but the holes for ears are kind of out of place, unless your maybe an elf");
            text = "Santa greets you at the door, 'HERE take this hat', Santa \n" +
                 "points to his watch as if that explains it all \n" +
                 "'HO HO HO-RRibly sorry but I am out of time to entertain visitors'\n " + northPoleArt + "\n" + addText;


        }

        public override void Run()
        {
           
            Scene.AddScene(this.GetType().Name);

            options = new string[] { "Ask why Santa is in a hurry", "Ask what you can do to help with Christmas", "Take magical hat", "Leave Santa's House", "View INVENTORY", "Exit Game" };
            
               base.Run();
            switch (optionsChoice)
            {
                case 1:
                    text = 
                        "'The Grinch has taken extra measures to destroy the christmas spirit by stealing presents\n" +
                        "namely on Main Street!'\n" +
                        "Santa tugs his sack to rest it more firmly on his shoulder. \n'As you may have seen from letters sent to the North Pole, there are distraught\n" +
                        "children on mainstreet it seems the grinch is messing with MY delivery system and now there is confusion\nthroughout the Elf delivery fleet! time is running out\n" +
                        "and I am in need of a CHRISTMAS MIRACLE " + northPoleArt + "\n" + addText; ;
                    myGame.mySantaScene.Run();
                    return;
                case 2:
                    text =
                         myGame.GetName().ToUpper() + ", you, can actually help by taking gifts, found in the workshop, to the proper addresses \n" +
                        "or *heaven forbid*, you could go to the grinch's mansion to comfront that PORCH THIEFING Bastard yourself!\n" +
                        "Go now, leave me. Oh and remember you will need a magic elf hat. You will need its magical elf embiding powers to allow you to make Christmas deliveries" + northPoleArt + "\n" + addText; ;

                   
                    myGame.mySantaScene.Run();
                    return;
                case 3:

                   
                    if (myGame.myInventory.Contains("Elf Hat"))
                    {
                        text = "Santa greets you at the door, 'HERE take this hat', Santa \n" +
     "points to his watch as if that explains it all \n" +
     "'HO HO HO-RRibly sorry but I am out of time to entertain visitors'\n " + northPoleArt + "\n" + addText;
                    }
                    else
                    {
                        addText = myGame.myInventory.invAdd(elfHat);
                        text = "Santa greets you at the door, 'HERE take this hat', Santa \n" +
     "points to his watch as if that explains it all \n" +
     "'HO HO HO-RRibly sorry but I am out of time to entertain visitors'\n " + northPoleArt + "\n" + addText;
                    }

                    myGame.mySantaScene.Run();
                    //addText = "";

                    return;
                case 4:
                    //open mailbox
                    
                    myGame.myNorthPoleScene.Run();
                    return;
                case 5:
                    if (ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else { myGame.myMainAreaScene.Run(); }
                    return;


            }
        }
    }
}
