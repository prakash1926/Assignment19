using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLip
{
    public class Triangle
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return 0.5 * Base * Height;
        }
    }
}
