using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I have used to float for GetNumber() and all the calculations involved to read and output the results with decimal values

namespace QuiltProject
{
    public class UserInputs
    {
        //initial input for pattern selection
        public void SelectPattern()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Select from the following : ");
            Console.WriteLine("S) Add a Square Pattern");
            Console.WriteLine("R) Add a Rectangular Pattern");
            Console.WriteLine("T) Add a Triangular Pattern");
            Console.WriteLine("L) List all the Pattern");
            Console.WriteLine();                //empty line
            Console.ResetColor();
        }

        //Reads string from user input
        public string GetString(string str)
        {
            // this color selection will get overridden when other methods with different color selections are called.
            Console.ForegroundColor = ConsoleColor.DarkMagenta;  
            Console.Write(str);
            return Console.ReadLine();
        }
       
        //Reads a number from user input.
        //Keeps looping back until a valid number is entered other than 0 (shapes cannot have 0 length).
        public float GetNumber(string str)
        {
            bool success = false;
            float value = 0.0f;
            Console.Write(str);

            do
            {
                success = float.TryParse(Console.ReadLine(), out value);

                if (!success || value == 0)
                {
                    Console.WriteLine("!!!Not a valid Input!!!");
                    Console.Write(str);
                }
            }
            while (!success || value == 0);

            return value;
        }

        //Returns true if the input is "Y" or "YES"
        public bool doContinue(string next)
        {
            return ((next == "Y" || next == "YES") ? true : false);
        }
    }
}
