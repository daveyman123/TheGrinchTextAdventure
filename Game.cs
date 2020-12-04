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

        //store the players name
        public string Name;
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
            
        }

        public static bool play = true;

        public static bool getPlay()
        {
            return play;
        }

        public void Start()
        {

            Console.Clear();
            Item itm = new Item("Elf Hat", "adsf");
            Item itm2 = new Item("letter", "adsf");
            myInventory.invAdd(itm);
            myInventory.invAdd(itm2);
            myGrinchMansionScene.Run();


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
    }
}
