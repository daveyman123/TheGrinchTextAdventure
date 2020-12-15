using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace TheGrinch.HelperFunctions
{
    class OptionsHelper

    {

        int selectedIndex;
        String[] opt = new String[] { "Play", "Credits", "Exit Game" };
        string prompt = "";


        public OptionsHelper(string prompt)
        {
            this.prompt = prompt;


        }
        public OptionsHelper(string[] opt)
        {
            this.opt = opt;


        }
        public OptionsHelper(string prompt, String[] opt)
        {
            this.opt = opt;
            this.prompt = prompt;
            //add inventory option to options

        }

        public void DisplayOptions()
        {

            int optionsHalfScreen = 50;
            int promptHelpHalfScreen = 50;
            int optBoxLen = 25;

            string output2 = "";

            string output = "";



            // output2 += "\nYour options are:\n";
            Console.WriteLine(prompt);
            Console.SetCursorPosition(promptHelpHalfScreen, 26);
            Console.WriteLine(output2);
            Console.SetCursorPosition(promptHelpHalfScreen, 27);


            Console.WriteLine("█████▓▒░    OPTIONS    ░▒▓█████");

            int count = 0;
            string prefix;
            for (int i = 0; i < opt.Length; i++)
            {

                string currentOption = opt[i];
                string currentOptionModified = "";


                int optExtend = 0;


                if (i == selectedIndex)
                {
                    prefix = "██*";
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(optionsHalfScreen, 28 + i);
                    currentOptionModified = currentOption + " ";
                    int z = currentOption.Length;


                    int optionCount = 25;
                    for (int n = 0; n < opt.Length; n++)
                    {


                        string currentOption2 = opt[n];
                        if (currentOption2.Length > optionCount)
                        {
                            optionCount = currentOption2.Length;
                        }
                    }
                    optExtend = optionCount;
                    while (z < optionCount)
                    {


                        currentOptionModified += " ";
                        z += 1;
                    }

                    currentOptionModified += "██";
                    Console.WriteLine(prefix + currentOptionModified);

                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = "██ ";
                    Console.SetCursorPosition(optionsHalfScreen, 28 + i);
                    currentOptionModified = currentOption + " ";
                    int z = currentOption.Length;


                    int optionCount = 25;
                    for (int n = 0; n < opt.Length; n++)
                    {


                        string currentOption2 = opt[n];
                        if (currentOption2.Length > optionCount)
                        {
                            optionCount = currentOption2.Length;
                        }
                    }
                    optExtend = optionCount;
                    while (z < optionCount)
                    {


                        currentOptionModified += " ";
                        z += 1;
                    }
                    currentOptionModified += "██";
                    Console.WriteLine(prefix + currentOptionModified);
                }

                Console.SetCursorPosition(promptHelpHalfScreen + 31, 27);

                string x = "";
                for (int l = 0; l < optExtend - 25; l++)
                {
                    x += "█";

                }
                Console.WriteLine(x);
                Console.SetCursorPosition(promptHelpHalfScreen, 28 + opt.Length);
                //extend top line of options box
                string j = "";
                for (int l = 0; l < optExtend + 6; l++)
                {

                    j += "█";

                }
                Console.WriteLine(j);
                optExtend = 0;

            }













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
                if (keyPressed == ConsoleKey.UpArrow)
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
            return selectedIndex + 1;
        }

    }
}

