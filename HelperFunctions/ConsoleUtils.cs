using System;
using System.Collections.Generic;
using System.Text;

namespace TheGrinch.HelperFunctions
{
    class ConsoleUtils
    {
       
        public static bool QuitConsole()
        { 
            string prompt = "Are you sure you wnat to exit? \n";
            string[] options = new string[] { "Yes", "No" };
            OptionsHelper Opt_Helper = new OptionsHelper(prompt, options);
            int Choice = Opt_Helper.MenuChoice();
            bool leaveGame = false;

            switch (Choice)
            {
                case 1:
                    
                    leaveGame = true;
                    break;
                case 2:
                    leaveGame = false;
                    break;

            }

            return leaveGame;
            
        }
    }
}
