using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltProject
{
   public class QuiltPattern
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public QuiltPattern(string color)
        {
            this.Color = color;
        }
        public virtual float getArea()
        {
            return 0.0f;
        }
        /*public virtual float getArea(float side1, float side2)
        {
            return side1 * side2;
        }*/
    }
}
