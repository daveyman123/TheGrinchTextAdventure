using System;
using System.Collections.Generic;
using System.Text;
using TheGrinch.HelperFunctions;
namespace TheGrinch.Scenes
{
    class Scene
    {
        protected Game myGame;
        public string text;

        public string[] options;
        public OptionsHelper opt_helper;
        public int optionsChoice;
        string previousScene;
        public static List<string> scenes;

        public Scene(Game game)
        {

            scenes = new List<string>();
            myGame = game;
            
        }

        virtual public void Run()
        {
            
            opt_helper = new OptionsHelper(text, options);
            optionsChoice = opt_helper.MenuChoice();
            // Runs the actual scene logic
            // Override in child classes

        
        }



        public static void AddScene(string scene)
        {
            scenes.Add(scene);
        }

        public static List<string> GetScene()
        {
            return scenes;
        }

        public OptionsHelper getOH()
        {
            return opt_helper;
        }
    }
}

