﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheGrinch.Scenes
{
    class BobbysHouse : Scene
    {
        Items BHItems;
        string art;
        string addtext;
        bool placed;
        public BobbysHouse(Game game) : base(game)
        {
            BHItems = new Items();
            art = Art.InHome();
            placed = false;
            text = "Everyone here is sleeping, However there are presents definitely missing!" +
" and that means the best bet is\n to find some presents and replace the missing ones before the residents wake\n"
+ art + addtext;


        }
        public override void Run()
        {
            Scene.AddScene(this.GetType().Name);



            options = new string[] { "Place down a present", "Leave house", "View Inventory", "Exit Game" };
            base.Run();
            switch (optionsChoice)
            {
                case 1:
                    if (myGame.myInventory.Contains("Bobbys Present"))
                    {
                        art = Art.InHomePresents();
                        
                        addtext = "\nyou've placed down a present for Bobby! everything should be taken care of at this house\n";
                        text = "Everyone here is still sleeping." +
" \n"
+ art + addtext;
                        myGame.myInventory.RemoveItem(myGame.myInventory.returnItem("Bobbys Present"));
                        placed = true;
                        myGame.SetFinished2(true);
                    }
                    else if (!placed)
                    {
                        art = Art.InHome();
                        addtext="\nyou dont have a present for Bobby\n";
                        
                    }    
                    myGame.myBobbysHouseScene.Run();
                    return;
                case 2:
                    addtext = "";
                    if (myGame.GetFinished1() == true && myGame.GetFinished2() == true)
                    {
                        myGame.myFlyOverScene.Run();
                    }
                    else
                    {
                        myGame.myMainStreetScene.Run();
                    }

                    return;

                case 3:
                    myGame.myInventoryScene.Run();
                    return;

                case 4:
                    if (TheGrinch.HelperFunctions.ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else { myGame.myReadLetterScene.Run(); }
                    return;


            }
        }
    }
}
