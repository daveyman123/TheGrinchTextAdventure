using System;
using System.Collections.Generic;
using System.Text;
using TheGrinch.Scenes;
using System.Media;
namespace TheGrinch
{
    class Game
    {
        //add inventory
        public Inventory myInventory;

        //add a soundplayer to the game
        SoundPlayer MusicPlayer;

        //current scene
        public string currentScene;
        //make scenes
        public Scene myTitleScene;
        public Scene myCreditsScene;
        public Scene myMainAreaScene;
        public Scene myNorthPoleScene;
        public Scene myReadLetterScene;
        public Scene myInventoryScene;
        public Scene myMainStreetScene;
        public Game()
        {
         
            
            //instantiate inventory
            myInventory = new Inventory();

            //instantiate soundplayer
            MusicPlayer = new SoundPlayer();

            //instantiate scenes
            myTitleScene = new TitleScene(this);
            myCreditsScene = new CreditsScene(this);
            myMainAreaScene = new MainArea(this);
            myNorthPoleScene = new NorthPole(this);
            myReadLetterScene = new ReadLetter(this);
            myInventoryScene = new InventoryScene(this);
            myMainStreetScene = new MainStreet(this);
            
        }

        public static bool play = true;

        public static bool getPlay()
        {
            return play;
        }

        public void Start()
        {

            Console.Clear();
            myMainAreaScene.Run();


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

        //set play state
        public static void setPlay(bool playState)
        {
            play = playState;
        }
    }
}
