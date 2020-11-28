using System;
using System.Collections.Generic;
using System.Text;

namespace TheGrinch.Scenes
{
    class InventoryScene : Scene
    {
        string art;
        string desc;
        int selectedItem;
        public InventoryScene(Game game) : base(game)
        {
            art = Art.bag();
            text = "";
            
        }

        public override void Run()
        {
            
            
         

            
         
            List<string> iterateOptions = new List<string>();

            //make the options helper print out options
            
            
            foreach(Item element in myGame.myInventory.invGet())
            {
                iterateOptions.Add(element.getName());
            }
            iterateOptions.Add("Close Inventory");
            options = iterateOptions.ToArray();

            
            if (myGame.myInventory.invGet().Count == 0)
            {
                text = art + "There is nothing in your inventory\n";
            }

            HelperFunctions.OptionsHelper opts_helper = new HelperFunctions.OptionsHelper(text, options);

            selectedItem = opts_helper.MenuChoice();
            if (selectedItem == iterateOptions.Count)
            {

                desc = "";

                art = Art.bag();
                text = art + desc;
                myGame.myMainAreaScene.Run();
                selectedItem = 0;

            }
            else if (selectedItem > 0)
            {
                
                desc = myGame.myInventory.invGet()[selectedItem-1].getDescription();
                text = art + desc + "\n\n" + "select an item to view its description \n";
                this.Run();
                selectedItem = 0;

            }
            else
            {
                return;
            }
            

           

        }
    }
}
