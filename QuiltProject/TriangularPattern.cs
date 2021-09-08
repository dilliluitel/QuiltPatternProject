using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltProject
{
    public class TriangularPattern : QuiltPattern
    {
        private float side1, side2, side3;
        UserInputs ui = new UserInputs();

        public TriangularPattern(string color) : base(color)
        {
            Name = "Triangular Pattern";
        }
        
        /*Calculate the area of Triangle from given three sides length.
         * Will return a NaN (not a number) if the provided sides fails to meet the requirement of Triangle Inequality Theorem.
         * Triangle Inequality Theorem : The sum of any two sides of a triangle is greater than or equal to the third side.
         */
        public override float GetArea()
        {
            side1 = ui.GetNumber("\nEnter side1 of your Triangle : ");
            side2 = ui.GetNumber("\nEnter side2 of your Triangle : ");
            side3 = ui.GetNumber("\nEnter side3 of your Triangle : ");

            float s = (side1 + side2 + side3) / 2;
            
            return (float)Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));   
        }

        /*public QuiltPattern CreateRectangularPattern()
       {
           Console.WriteLine("You have selected Rectangular Pattern.");
           var color = ui.GetString();  //ask user input for color
           side1 = ui.GetNumber("Enter side1 of your Triangle : ");    
           side2 = ui.GetNumber("Enter side2 of your Triangle : ");
           side3 = ui.GetNumber("Enter side3 of your Triangle : ");

           return new QuiltPattern(color);
       }*/
    }
}
