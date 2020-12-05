using System;
using System.Collections.Generic;
using System.Text;

namespace TheGrinch.Scenes
{
    class GetName : Scene
    {
        
        public GetName(Game game) : base(game)
        {
          
            
            
        }
        public override void Run()
        {
            Console.Clear();
            Scene.AddScene(this.GetType().Name);
            options = new string[] { "ok, " + myGame.Name+ " to progress through the game", 
            "you will be selecting from this menu",
            "by using the arrow keys and watching for the * next to",
            "the selected option",
            "select anything to continue to the Train Depot"
            };
           

            opt_helper = new HelperFunctions.OptionsHelper("Welcome to The Grinch game\n\n", options);
            if (myGame.GetName() == "")
            {
                Console.WriteLine("\nThe time is 5AM December 25th in WhoVille\n\n" +
                "Your task is undo the grinch's attempts to undo christmas by replacing the presents he stole\n" +
                Art.Grinch() + "\n\n" +
                "Please enter your name: \n");
                string namez = Console.ReadLine();
                myGame.SetName(namez);
                myGame.myGetNameScene.Run();
            }
            else
            {
                base.Run();
               
                myGame.myMainAreaScene.Run();
            }

        }
    }
}
