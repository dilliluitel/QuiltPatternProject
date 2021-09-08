using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltProject
{
   public class RectangularPattern : QuiltPattern
    {
        private float length, width;
        UserInputs ui = new UserInputs();

        public RectangularPattern(string color) : base(color)
        {
            Name = "Rectangular Pattern";
        }
       
        public override float GetArea()
        {
            length = ui.GetNumber("\nEnter length of your Rectangle : ");
            width = ui.GetNumber("\nEnter width of your Rectangle : ");

            return length * width;
        }

       /* public QuiltPattern CreateRectangularPattern()
        {
            Console.WriteLine("You have selected Rectangular Pattern.");
            var color = ui.GetString();  //ask user input for color
            length = ui.GetNumber("Enter length of Rectangle : ");
            width = ui.GetNumber("Enter width of Rectangle : ");

            return new QuiltPattern(color);
        }*/
    }
}
