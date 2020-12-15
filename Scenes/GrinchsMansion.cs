using System;
using System.Collections.Generic;
using System.Text;
using TheGrinch.HelperFunctions;
namespace TheGrinch.Scenes
{
    class GrinchsMansion : Scene
    {
        string grinchArt;
        string addText;
        Item SuzysPresent;
        string addText2;

        public GrinchsMansion(Game game) : base(game)
        {
            SuzysPresent = new Item("Suzys Present", "A neatly wrapped box that contains a toy doll");

           

            text = "It's cold here, and the Grinches presence only makes it seem colder.\n" + ArtReadHelper.ascii("Grinch1")
                +"\nWell hello there!";
            addText2 = "\n'Yes I have destroyed Christmas.' *smiles* 'It is because I dont believe in the Joy of Christmas!'";

        }

        public override void Run()
        {

          
          

            Scene.AddScene(this.GetType().Name);

            string[] options = new string[] { "Talk to the Grinch", "Prove to the Grinch that there is joy in christmas", "Leave the Grinches Mansion","View INVENTORY", "Exit Game" };
            
            HelperFunctions.OptionsHelper Opt_Helper = new HelperFunctions.OptionsHelper(text, options);
            int Choice = Opt_Helper.MenuChoice();
            switch (Choice)
            {
                case 1:
                    if (myGame.myInventory.Contains("Suzys Present"))
                    {

                        text = "The Grinch's heart has grown 3 sizes and he now sees the joy of christmas\n" + ArtReadHelper.ascii("Grinch1");


                    }
                    else
                    {
                        text = "It's cold here, and the Grinches presence only makes it seem colder.\n" + ArtReadHelper.ascii("Grinch1")
                            + addText2;
                    }

                    myGame.myGrinchMansionScene.Run();
                    return;
                case 2:
                    if (myGame.myInventory.Contains("letter"))
                    {
                        addText2 = "";
                        

                        addText = "\nYou show the Grinch Suzy's letter\n\n" +
                            "The Grinch reads the letter and his demeanor changes, his heart grows 3 sizes" +
                            "and he says 'I never realized a child could be so unselfish'";
                        //add suzys present to the players inventory if its not already there
                        if (myGame.myInventory.Contains("Suzys Present"))
                        {
                            addText += "\n\nThe Grinch already gave you the present";

                        }
                        else
                        {
                            addText += "\n\n" + myGame.myInventory.invAdd(SuzysPresent);

                        }

                        text = "The Grinch's heart has grown 3 sizes and he now sees the joy of christmas\n" + ArtReadHelper.ascii("Grinch1");
                        text = text +addText + addText2;
                        myGame.myGrinchMansionScene.Run();
                    }
                    else
                    {
                        addText = "You dont have any proof, maybe if the Grinch saw a letter to santa he would be persuaded to end his sabatoge";
                       text = "It's cold here, and the Grinches presence only makes it seem colder.\n" + ArtReadHelper.ascii("Grinch1") + "\n" + addText;
                       
                    }
                    myGame.myGrinchMansionScene.Run();
                    return;
                case 3:
                    //open mailbox
                    
                    myGame.myMainStreetScene.Run();
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
