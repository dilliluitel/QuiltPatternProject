using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Base class for the different Quilt patterns.

namespace QuiltProject
{
   public class QuiltPattern
    {
        public string Name { get; set; }
        public string Color { get; set; }
       // public float Area { get; set; }

        public QuiltPattern(string color)
        {
            this.Color = color;
        }
        public virtual float GetArea()
        {
            return 0.0f;
        }
    }
}
