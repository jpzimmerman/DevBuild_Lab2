using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.GrandCircusClassrooms
{
    class RectangularRoom
    {
        public double Width { get; set; } = 0.0;
        public double Length { get; set; } = 0.0;
        public double Area { get { return Width * Length; } }
        public double Perimeter { get { return (2f * Width) + (2f * Length); } }

        public RectangularRoom()
        {

        }

    }
}
