using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice_02.Geometry.Interfaces;

namespace Practice_02.Geometry.Implementation
{
    class Tetrahedron : IFigure3D
    {
        public double sideA;
        public double sideB;
        public double baseSideC;
        public double height;
        public Tetrahedron(double sideA, double sideB, double baseSideC, double height)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.baseSideC = baseSideC;
            this.height = height;
        }

        public double Volume {get;}

        public double SurfaceArea => throw new NotImplementedException();
        // public double Volume => ((sideA * sideB * baseSideC) / 12) * System.Math.Sqrt(2);
        //public double SurfaceArea => sideA * sideB * System.Math.Sqrt(3);



    }
}
