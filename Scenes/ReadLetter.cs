using System;
using System.Collections.Generic;
using System.Text;
using TheGrinch.HelperFunctions;
namespace TheGrinch.Scenes
{
    class ReadLetter : Scene
    {
        string letterText;
        Inventory Inv;
        OptionsHelper opts_helper;

        public ReadLetter(Game game) : base(game)
        {
            Inv = myGame.myInventory;
            

        }

        public override void Run()
        {
            scenes.Add(this.GetType().Name);

            //for this specific class take the art + the text of the letter we want to print out
            text = Art.Letter() + "\n" +letterText+"\n";
            options = new string[]{ "take letter", "leave letter", "leave mailbox", "Exit Game" };
            
            //create a new item
            Item letterItem = new Item("letter", "The hand writing on the letter is hard to make out but it appears to be a letter addressed to Santa \n'WE ARE CRYING BECAUSE WE DID NOT RECIEVE OUR PRESENTS THIS YEAR!!' signed Susy.");
            //create specific scene items
            Items mailboxItems = new Items(letterItem);

            //instantiate options helper
            opts_helper = new OptionsHelper(text, options);
          
            switch (this.opts_helper.MenuChoice())
            {
                case 1:

                    //myGame.myInventory.invAdd(letterItem);
                    if (myGame.myInventory.Contains("letter"))
                    {
                        letterText = "You already picked up the letter";
                    }
                    else
                    {
                        letterText = myGame.myInventory.invAdd(mailboxItems.returnItem("letter"));
                        
                    }
                    
                    myGame.myReadLetterScene.Run();

                    return;
                case 2:
                    if (myGame.myInventory.returnItem("letter") != null)
                    {
                        letterText = myGame.myInventory.RemoveItem(myGame.myInventory.returnItem("letter"));
                       
                    }
                    else
                    {
                        letterText = "you havent picked up the letter";
                    }
                    myGame.myReadLetterScene.Run();
                    
                    return;
                case 3:
                    myGame.myNorthPoleScene.Run();
                    return;
                case 4:
                    if (ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else { myGame.myReadLetterScene.Run(); }
                    return;
            }
}
    }
}
