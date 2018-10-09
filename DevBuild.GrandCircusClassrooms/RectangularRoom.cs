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
        public double Height { get; set; } = 0.0;
        public double Area { get { return Math.Abs(Width * Length); } }
        public double Perimeter { get { return Math.Abs(2f * Width) + Math.Abs(2f * Length); } }
        public double Volume { get { return Math.Abs(Area * Height); } }

        public RectangularRoom()
        {

        }

    }
}
