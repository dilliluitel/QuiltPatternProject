using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltProject
{
    public class TriangularPattern : QuiltPattern
    {
        public TriangularPattern(string color) : base(color)
        {
            Name = "Triangular Pattern";
        }
        private float side1, side2, side3;
        

        UserInputs ui = new UserInputs();

        public override float getArea()
        {
            side1 = ui.sideLength();
            side2 = ui.sideLength();
            side3 = ui.sideLength();

            return side1 * side2 * side3;
        }
    }
}
