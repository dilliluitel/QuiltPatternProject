using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltProject
{
    public class SquarePattern : QuiltPattern
    {
       // private static string Name;
        private float length;
        public SquarePattern(string color) : base(color)
        {
            Name = "Square Pattern";
           // Color = color;
        }

        UserInputs ui = new UserInputs();
        
        public override float getArea()
        {
            length = ui.sideLength();

            return length * length;
        }

        /*public QuiltPattern createSquarePattern()
        {
            Console.WriteLine("You have selected Square pattern.");
            var color = "Red";  //ask for user
            length = 5;    //ask for user

            return new QuiltPattern(color); 
        }

        public static implicit operator List<object>(SquarePattern v)
        {
            throw new NotImplementedException();
        }*/
    } 
}
