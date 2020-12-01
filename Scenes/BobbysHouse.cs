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
        public BobbysHouse(Game game) : base(game)
        {
            BHItems = new Items();
            art = Art.InHome();
            text = "Everyone here is sleeping, However there are presents definitely missing!" +
"and that means the best bet is\n to find some presents and replace the missing ones before the residents wake\n"
+ art;
        }
        public override void Run()
        {
            Scene.AddScene(this.GetType().Name);



            options = new string[] { "place down a present", "leave house", "View Inventory", "Exit Game" };
            base.Run();
            switch (optionsChoice)
            {
                case 1:
                    if (!BHItems.Contains("Bobbys Present") && myGame.myInventory.Contains("Bobbys Present"))
                    {
                        art = Art.InHomePresents();
                        
                        addtext = "\nyou've placed down a present for Bobby! everything should be taken care of at this house\n";
                        text += addtext;
                    }
                    else
                    {
                        art = Art.InHome();
                        addtext="\nyou dont have a present for Bobby\n";
                        text += addtext;
                    }    
                    myGame.myBobbysHouseScene.Run();
                    return;
                case 2:
                    myGame.myMainStreetScene.Run();
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