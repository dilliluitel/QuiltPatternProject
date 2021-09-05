using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltProject
{
   public class RectangularPattern : QuiltPattern
    {
        public RectangularPattern(string color) : base(color)
        {
            Name = "Rectangular Pattern";
        }
        private float length, width;

        UserInputs ui = new UserInputs();

        public override float getArea()
        {
            length = ui.sideLength();
            width = ui.sideLength();

            return length * width;
        }
    }
}
