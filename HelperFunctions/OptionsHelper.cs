using System;
using System.Linq;
using System.Text;

namespace TheGrinch.HelperFunctions
{
    class OptionsHelper
    {
        String[] opt = new String[] { "Go to the North Pole", "Go to the Grinches Mansion", "Go to the Park", "Exit Game" };
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
        }

        public int MenuChoice()
        {

            string output = "";
            output += "\n " + prompt + "\n";
            int Choice = 0;
            output += "Your options are: ";
            int counter = 1;
            for (int i = 0; i < opt.Length - 1; i++)
            {

                output += counter + ") " + opt[i] + " or ";
                counter = counter + 1;

            }

            output += opt.Length + ") " + opt[opt.Length - 1] + "\nType a number corresponding to your choice \n";
            Console.WriteLine(output);
            string input = Console.ReadLine();

            Console.Clear();
            int.TryParse(input, out Choice);

            bool isNumeric = (!string.IsNullOrEmpty(input) && input.All(Char.IsDigit));



            while (!isNumeric || Choice > opt.Length || Choice <= 0)
            {
                Console.WriteLine(output);
               
                Console.WriteLine("you must enter a digit between 1-" + opt.Length);
               
                input = Console.ReadLine();


                int.TryParse(input, out Choice);

                isNumeric = !string.IsNullOrEmpty(input) && input.All(Char.IsDigit);


            }
            Console.Clear();
            return Choice;
        }
    }
}