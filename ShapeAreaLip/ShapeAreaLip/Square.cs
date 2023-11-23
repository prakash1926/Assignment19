using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLip
{
    public class Square
    {
        public double Side { get; set; }

        public double Area()
        {
            return Side * Side;
        }
    }
}
