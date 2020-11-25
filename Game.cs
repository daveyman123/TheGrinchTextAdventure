using System;
using System.Collections.Generic;
using System.Text;
using TheGrinch.Scenes;
using System.Media;
namespace TheGrinch
{
    class Game
    {
        //add a soundplayer to the game
        SoundPlayer MusicPlayer;

        //make scenes
        public Scene myTitleScene;
        public Scene myCreditsScene;
        public Scene myMainAreaScene;
        public Game()
        {

            //instantiate soundplayer
            MusicPlayer = new SoundPlayer();

            //instantiate scenes
            myTitleScene = new TitleScene(this);
            myCreditsScene = new CreditsScene(this);
            myMainAreaScene = new MainArea(this);
            
        }

        public static bool play = true;

        public static bool getPlay()
        {
            return play;
        }

        public void Start()
        {

            Console.Clear();
            myTitleScene.Run();


        }
        public void End()
        {
            //end for player
            HelperFunctions.ConsoleUtils.QuitConsole();
        }
            
        //get soundplayer
        public SoundPlayer getSoundPlayer()
        {
            return MusicPlayer;
        }
    }
}
