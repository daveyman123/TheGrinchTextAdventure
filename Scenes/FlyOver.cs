using System;
using System.Collections.Generic;
using System.Text;
using System.Media;
using TheGrinch.HelperFunctions;
namespace TheGrinch.Scenes
{
    class FlyOver : Scene
    {
        int Choice;
        string addText;
        OptionsHelper Opt_Helper;
        string addArt;
        string thisText;
        public FlyOver(Game game) : base(game)
        {
            addArt = Art.FlyOver1();
            text =""
                +addArt;

           
            Opt_Helper = new OptionsHelper(text,options);
        }

        public override void Run()
        {
            SoundPlayer mainSoundPlayer = myGame.getSoundPlayer();
            mainSoundPlayer.SoundLocation = "Audio/SantaHoHoHo.wav";
            mainSoundPlayer.Load();
            mainSoundPlayer.Play();
        

        Opt_Helper = new OptionsHelper(text,options);

            options = new string[] { "You won the game!!" };


   
         
            System.Threading.Thread.Sleep(1000);
            addArt = Art.FlyOver2();
           text = ""
               
                
                + addArt;
            Opt_Helper = new OptionsHelper(text,options);
            Console.Clear();
            Opt_Helper.DisplayOptions();

            System.Threading.Thread.Sleep(1000);
            addArt = Art.FlyOver3();
            text =               
                ""
                + addArt;
            Opt_Helper = new OptionsHelper(text,options);
            Console.Clear();
            Opt_Helper.DisplayOptions();
            System.Threading.Thread.Sleep(1000);
            addArt = Art.FlyOver4();
            text = 
                ""
                + addArt;
            Opt_Helper = new OptionsHelper(text,options);
            Console.Clear();
            Opt_Helper.DisplayOptions();
            System.Threading.Thread.Sleep(1000);
            addArt = Art.FlyOver5();
            text =
                ""
                + addArt;
            Console.Clear();


            addArt = Art.FlyOver6();
            text =
                ""
                + addArt;
            Opt_Helper = new OptionsHelper(text,options);
            Console.Clear();
            Opt_Helper.DisplayOptions();
            System.Threading.Thread.Sleep(1000);
            addArt = Art.FlyOver7();
            text = 
                ""
                + addArt;
            Console.Clear();
            addArt = Art.FlyOver7();
            text = 
                ""
                + addArt;
            Opt_Helper = new OptionsHelper(text,options);
            Console.Clear();
            Opt_Helper.DisplayOptions();
            System.Threading.Thread.Sleep(5000);

            myGame.myCreditsScene.Run();


        }
    }
}
