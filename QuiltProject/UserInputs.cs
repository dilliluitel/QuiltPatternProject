using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltProject
{
    public class UserInputs
    {
        public void select()
        {
            Console.WriteLine("Select from the following : ");
            Console.WriteLine("S) Add a Square Pattern");
            Console.WriteLine("R) Add a Rectangular Pattern");
            Console.WriteLine("T) Add a Triangular Pattern");
            Console.WriteLine("L) List all the Pattern");
            Console.WriteLine();                //empty line
        }

        public float sideLength()
        {
            Console.Write("\nEnter the length of a side : ");
            
            return float.Parse(Console.ReadLine());
        }
        public bool doContinue(string next)
        {
            return ((next == "Y" || next == "YES") ? true : false);
        }
    }
}
