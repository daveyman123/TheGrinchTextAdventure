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


        //make scenes
        public Scene myTitleScene;
        public Scene myCreditsScene;
        public Scene myMainAreaScene;
        public Scene myNorthPoleScene;
        public Scene myReadLetterScene;
        public Scene myInventoryScene;
        public Scene myMainStreetScene;
        public Scene mySuzysHouseScene;
        public Scene myBobbysHouseScene;
        public Scene myWorkshopScene;
        public Scene mySantaScene;
        public Scene myGetNameScene;
        public Scene myGrinchMansionScene;
        public Scene myFlyOverScene;

        //store the players name
        public string Name;

        //goal for game
        //could do better on protection levels
        public bool finished1;
        public bool finished2;
        public Game()
        {

            //instantiate players name as blank
            Name = "";
            //instantiate inventory
            myInventory = new Inventory();

            //instantiate soundplayer
            MusicPlayer = new SoundPlayer();

            //instantiate scenes
            myGetNameScene = new GetName(this);
            myTitleScene = new TitleScene(this);
            myCreditsScene = new CreditsScene(this);
            myMainAreaScene = new MainArea(this);
            myNorthPoleScene = new NorthPole(this);
            myWorkshopScene = new Workshop(this);
            myReadLetterScene = new ReadLetter(this);
            myInventoryScene = new InventoryScene(this);
            myMainStreetScene = new MainStreet(this);
            myBobbysHouseScene = new BobbysHouse(this);
            mySuzysHouseScene = new SuzysHouse(this);
            mySantaScene = new SantasHouse(this);
            myGrinchMansionScene = new GrinchsMansion(this);
            myFlyOverScene = new FlyOver(this);

            //instantiate game goal bool
            finished1 = false;
            finished2 = false;
            
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

        //set play state
        public static void setPlay(bool playState)
        {
            play = playState;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        //get whether game is finished
        public bool GetFinished1()
        {
            return finished1;
        }
        public bool GetFinished2()
        {
            return finished2;
        }

        //set whether game is finished
        public void SetFinished1(bool fnsh) {
            finished1 = fnsh;
        }
        public void SetFinished2(bool fnsh)
        {
            finished2 = fnsh;
        }
    }
}
