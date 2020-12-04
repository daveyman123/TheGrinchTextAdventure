using System;
using System.Collections.Generic;
using System.Text;
using TheGrinch.HelperFunctions;
using System.Media;
namespace TheGrinch.Scenes
{
    class MainArea : Scene
    {
        string mainArt;
        OptionsHelper Opt_Helper;
        public MainArea(Game game) : base(game)
        {
            mainArt = "The train pulls up to the Train Depot and passengers scramble to disembark and board. \n"+Art.Train();


            Opt_Helper = new OptionsHelper(mainArt);
        }


        public override void Run()

        {
            Scene.AddScene(this.GetType().Name);

            if (GetScene()[scenes.Count - 2] != "InventoryScene") 
            { 
            SoundPlayer mainSoundPlayer = myGame.getSoundPlayer();
            mainSoundPlayer.SoundLocation = "Audio/train.wav";
            mainSoundPlayer.Load();
            mainSoundPlayer.Play();
             }
            


            int Choice = Opt_Helper.MenuChoice();

            switch (Choice)
            {
                case 1:
                    //go to north pole
                    System.Threading.Thread.Sleep(1000);
                    mainArt = "The train is leaving for the north pole. \n" + Art.Train2();
                    Opt_Helper = new OptionsHelper(mainArt);
                    Console.Clear();
                    Opt_Helper.DisplayOptions();
                    
                    System.Threading.Thread.Sleep(1000);
                    mainArt = "The train is leaving for the north pole.. \n" + Art.Train3();
                    Opt_Helper = new OptionsHelper(mainArt);
                    Console.Clear();
                    Opt_Helper.DisplayOptions();
                    System.Threading.Thread.Sleep(1000);
                    mainArt = "The train is leaving for the north pole... \n" + Art.Train4();
                    Opt_Helper = new OptionsHelper(mainArt);
                    Console.Clear();
                    Opt_Helper.DisplayOptions();
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    mainArt = "The train pulls up to the Train Depot and passengers scramble to disembark and board. \n" + Art.Train();
                    Opt_Helper = new OptionsHelper(mainArt);
                    myGame.myNorthPoleScene.Run();
                    return;

                case 2:
                    //go to Main street
                    myGame.myMainStreetScene.Run();
                    return;
                case 3:
                    myGame.myInventoryScene.Run();
                    return;
                case 4:
                    //System.Threading.Thread.Sleep(100);
                    if (ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else { myGame.myMainAreaScene.Run(); }
                    return;
            }
        }
    }
}
