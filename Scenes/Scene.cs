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
        int optionsChoice;
        string currentScene;

        public Scene(Game game)
        {
            
           
            myGame = game;
            
        }

        virtual public void Run()
        {
            OptionsHelper opt_helper = new OptionsHelper(text, options);
            optionsChoice = opt_helper.MenuChoice();
            // Runs the actual scene logic
            // Override in child classes
            //currentScene = this.GetType().Name;
        }

    }
}

