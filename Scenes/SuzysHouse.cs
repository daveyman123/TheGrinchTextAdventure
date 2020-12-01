﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheGrinch.Scenes
{
    class SuzysHouse : Scene
    {
        Items SHItems;
        string art;
        string addtext;

        public SuzysHouse(Game game) : base(game)
        {
            SHItems = new Items();
            art = Art.InHome();

        }
        public override void Run()
        {
            Scene.AddScene(this.GetType().Name);

            text = "Everyone here is sleeping, However there are presents definitely missing!" +
" and that means the best bet is\n to find some presents and replace the missing ones before the residents wake\n"
+ art + addtext;

            options = new string[] { "place down a present", "leave house", "View Inventory", "Exit Game" };
            base.Run();
            switch (optionsChoice)
            {
                case 1:
                    if (!SHItems.Contains("Suzys Present") && myGame.myInventory.Contains("Suzys Present"))
                    {
                        art = Art.InHomePresents();

                        addtext = "\nyou've placed down a present for Suzy! everything should be taken care of at this house\n";
                        myGame.myInventory.RemoveItem(myGame.myInventory.returnItem("Suzys Present"));
                    }
                    else
                    {
                        art = Art.InHome();
                        addtext = "\nyou dont have a present for Suzy\n";

                    }
                    myGame.mySuzysHouseScene.Run();
                    return;
                case 2:
                    addtext = "";
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