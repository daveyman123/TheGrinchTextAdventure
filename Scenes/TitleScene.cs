using System;
using System.Collections.Generic;
using System.Text;
using TheGrinch.HelperFunctions;
using System.Media;
namespace TheGrinch.Scenes
{
    class TitleScene : Scene
    {
        //ascii art strings
        string art;
        string name;
        string combinedArt;

        //options
        string[] options;

        //options helper
        OptionsHelper opt_helper;

        //make a soundplayer
        SoundPlayer MusicPlayer;


        public TitleScene(Game game) : base(game)
        {



            //assign art to string properties
            art = "";
            name = ArtReadHelper.ascii("Title");
            combinedArt = name + "\n" + art;
            //create some options
            options = new string[] { "Play", "Quit", "Credits" };

            //create optionshelper
            opt_helper = new OptionsHelper(combinedArt, options);
        }
        public override void Run()
        {
            scenes.Add(this.GetType().Name);

            //get soundplayer
            MusicPlayer = myGame.getSoundPlayer();
            MusicPlayer.SoundLocation = "Audio/mainMusic.wav";

            //load and play music
            MusicPlayer.Load();
            MusicPlayer.PlayLooping();

            //write it all to console and get the choice using the OptionsHelper class



            int choice = opt_helper.MenuChoice();

            //switch on the choice

            switch (choice)
            {
                case 1:
                    
                    myGame.myGetNameScene.Run();
                    return;
                case 2:
                    if (ConsoleUtils.QuitConsole()) { Environment.Exit(0); } else { myGame.myMainAreaScene.Run(); }
                    return;
                case 3:
                    myGame.myCreditsScene.Run();
                    return;


            }



        }
    }
}

