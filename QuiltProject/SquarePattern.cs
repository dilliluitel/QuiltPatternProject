using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltProject
{
    public class SquarePattern : QuiltPattern
    {
        private float length;
        UserInputs ui = new UserInputs();

        public SquarePattern(string color) : base(color)
        {
            this.Name = "Square Pattern";
        }
        public override float GetArea()
        {
            length = ui.GetNumber("\nEnter length of your Square : ");

            return length * length;
        }

       /* public QuiltPattern CreateSquarePattern() 
        {
            Console.WriteLine("You have selected Square Pattern.");
            var color = ui.GetString("");  //ask user input for color
            length = ui.GetNumber("Enter length of Square : ");    //ask user input for square length

            return new QuiltPattern(color); 
        }*/
    } 
}
