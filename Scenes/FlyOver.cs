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
            text = "You did it you were successful in saving christmas! everyone is happy on mainstreet\n"
                + "                              MERRY CHRISTMAS TO ALL AND TO ALL A GOOD NIGHT " +
                ""
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

            options = new string[] { "" };


   
         
            System.Threading.Thread.Sleep(1000);
            addArt = Art.FlyOver2();
            text = "You did it you were successful in saving christmas! everyone is happy on mainstreet\n"
                + "                              MERRY CHRISTMAS TO ALL AND TO ALL A GOOD NIGHT " +
                ""
                + addArt;
            Opt_Helper = new OptionsHelper(text,options);
            Console.Clear();
            Opt_Helper.DisplayOptions();

            System.Threading.Thread.Sleep(1000);
            addArt = Art.FlyOver3();
            text = "You did it you were successful in saving christmas! everyone is happy on mainstreet\n"
                + "                              MERRY CHRISTMAS TO ALL AND TO ALL A GOOD NIGHT " +
                ""
                + addArt;
            Opt_Helper = new OptionsHelper(text,options);
            Console.Clear();
            Opt_Helper.DisplayOptions();
            System.Threading.Thread.Sleep(1000);
            addArt = Art.FlyOver4();
            text = "You did it you were successful in saving christmas! everyone is happy on mainstreet\n"
                + "                              MERRY CHRISTMAS TO ALL AND TO ALL A GOOD NIGHT " +
                ""
                + addArt;
            Opt_Helper = new OptionsHelper(text,options);
            Console.Clear();
            Opt_Helper.DisplayOptions();
            System.Threading.Thread.Sleep(1000);
            addArt = Art.FlyOver5();
            text = "You did it you were successful in saving christmas! everyone is happy on mainstreet\n"
                + "                              MERRY CHRISTMAS TO ALL AND TO ALL A GOOD NIGHT " +
                ""
                + addArt;
            Console.Clear();


            addArt = Art.FlyOver6();
            text = "You did it you were successful in saving christmas! everyone is happy on mainstreet\n"
                + "                              MERRY CHRISTMAS TO ALL AND TO ALL A GOOD NIGHT " +
                ""
                + addArt;
            Opt_Helper = new OptionsHelper(text,options);
            Console.Clear();
            Opt_Helper.DisplayOptions();
            System.Threading.Thread.Sleep(1000);
            addArt = Art.FlyOver7();
            text = "You did it you were successful in saving christmas! everyone is happy on mainstreet\n"
                + "                              MERRY CHRISTMAS TO ALL AND TO ALL A GOOD NIGHT " +
                ""
                + addArt;
            Console.Clear();
            addArt = Art.FlyOver7();
            text = "You did it you were successful in saving christmas! everyone is happy on mainstreet\n"
                + "                              MERRY CHRISTMAS TO ALL AND TO ALL A GOOD NIGHT " +
                ""
                + addArt;
            Opt_Helper = new OptionsHelper(text,options);
            Console.Clear();
            Opt_Helper.DisplayOptions();
            System.Threading.Thread.Sleep(5000);
           



        }
    }
}
