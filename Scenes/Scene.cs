using System;
using System.Collections.Generic;
using System.Text;

namespace TheGrinch.Scenes
{
    class Scene
    {
        protected Game myGame;
        
        public Scene(Game game)
        {
            myGame = game;
        }

        virtual public void Run()
        {
            // Runs the actual scene logic
            // Override in child classes
        }


    }
}

