﻿using System;
using System.Linq;
using System.Text;
using static System.Console;

namespace TheGrinch.HelperFunctions
{
    class OptionsHelper

    {
        int selectedIndex;
        String[] opt = new String[] { "Go to the North Pole", "Go to the Grinches Mansion", "Go to the Park", "Exit Game" };
        string prompt = "";

        public OptionsHelper(string prompt)
        {
            this.prompt = prompt;
            int selectedIndex;
        }
        public OptionsHelper(string[] opt)
        {
            this.opt = opt;
            int selectedIndex;
        }
        public OptionsHelper(string prompt, String[] opt)
        {
            this.opt = opt;
            this.prompt = prompt;
            int selectedIndex;
        }

        private void DisplayOptions()
        {

            string output = "";
            output += "\n " + prompt + "\n";
            
            output += "\n\nYour options are: \n";
            
            
            string prefix;
            for (int i = 0; i < opt.Length; i++)
            {
                string currentOption = opt[i];
                

                if (i == selectedIndex)
                {
                    prefix = "*";
                    
                }
                else
                {
                    prefix = " ";
                    
                }

                output += prefix + opt[i] + "\n";
                
            }

            Console.WriteLine("\nUse the arrow keys to select your choice and press enter \n");
            Console.WriteLine(output);
           

        





          
           
        }
        public int MenuChoice()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                if(keyPressed == ConsoleKey.UpArrow)
                {

                    selectedIndex--;
                    if (selectedIndex == -1)
                    {
                        selectedIndex = opt.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex == opt.Length)
                    {
                        selectedIndex = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);
            return selectedIndex +1;
        }
    }
}