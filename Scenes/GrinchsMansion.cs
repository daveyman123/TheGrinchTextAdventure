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
        public GrinchsMansion(Game game) : base(game)
        {
            addText = "well hello there!";
            
            

        }

        public override void Run()
        {
            text = "It's cold here and the mood is somber, Given all the distressful letters in the mailbox.\n" + ArtReadHelper.ascii("Grinch1") + "\n" + addText;

            Scene.AddScene(this.GetType().Name);

            string[] options = new string[] { "Talk to the Grinch", "Go to Santa's House", "Open the Mail Box", "Leave the North Pole","View INVENTORY", "Exit Game" };
            
            HelperFunctions.OptionsHelper Opt_Helper = new HelperFunctions.OptionsHelper(text, options);
            int Choice = Opt_Helper.MenuChoice();
            switch (Choice)
            {
                case 1:
                    addText = "'Yes I have destroyed Christmas.' *smiles* 'It is because I dont believe in the Joy of Christmas!'";
                    myGame.myGrinchMansionScene.Run();
                    return;
                case 2:
                    myGame.mySantaScene.Run();
                    return;
                case 3:
                    //open mailbox
                    
                    myGame.myReadLetterScene.Run();
                    return;
                case 4:
                    myGame.myMainAreaScene.Run();
                    return;
                case 5:
                    myGame.myInventoryScene.Run();
                    return;
                case 6:
                    if (ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else { myGame.myMainAreaScene.Run(); }
                    return;


            }
        }
    }
}
