using System;
using System.Collections.Generic;
using System.Text;
using TheGrinch.HelperFunctions;
namespace TheGrinch.Scenes
{
    class Workshop : Scene
    {
        string addText;
        string presentText;
        public Workshop(Game game) : base(game)
        {

            addText = "In the return to\n" +
        "senders bin is a present addressed to BOBBY 1421 Main Street, You get a feeling this shouldnt be here though";



        }

        public override void Run()
        {
            Scene.AddScene(this.GetType().Name);
          
            text = "There is lots of hustle and bustle here in the hours before christmas. " + addText;
           Item BPresent = new Item("Bobbys Present", "The present for bobby is a toy train in a box.");
            Items WorkshopItems = new Items(BPresent);
            string[] options = new string[] { "Pick up Bobbys Present", "Leave Bobby's Present", "Leave the Workshop","View INVENTORY", "Exit Game" };
            string northPoleArt = text + Art.Elf2() + presentText;
            HelperFunctions.OptionsHelper Opt_Helper = new HelperFunctions.OptionsHelper(northPoleArt, options);
            int Choice = Opt_Helper.MenuChoice();
            switch (Choice)
            {
                case 1:
                    if (myGame.myInventory.Contains("Bobbys Present"))
                    {
                        presentText = "\nYou already picked up the present";
                    }
                    else
                    {
                        presentText = myGame.myInventory.invAdd(WorkshopItems.returnItem("Bobbys Present"));
                        addText = "";
                    }

                    myGame.myWorkshopScene.Run();

                    return;
                 
                case 2:
                    if (myGame.myInventory.returnItem("Bobbys Present") != null)
                    {
                        presentText = myGame.myInventory.RemoveItem(myGame.myInventory.returnItem("Bobbys Present"));

                    }
                    else
                    {
                        presentText = "you havent picked up the present";
                    }
                 
                    myGame.myWorkshopScene.Run();
                    return;
                case 3:
                    myGame.myNorthPoleScene.Run();
                    return;
                case 4:
                    myGame.myInventoryScene.Run();
                    return;
                    
                 

                case 5:
                    if (ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else { myGame.myMainAreaScene.Run(); }
                    return;


            }
        }
    }
}
