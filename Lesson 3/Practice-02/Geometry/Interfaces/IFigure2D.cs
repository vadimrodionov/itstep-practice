using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_02.Geometry.Interfaces
{
    interface IFigure2D:IFigure
    {
        double Area { get; set; }
    }
}
