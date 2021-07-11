using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Practice_01
{
    abstract class Vector
    {
        public abstract double AbsoluteValue{ get;}
        public abstract bool IsNormal();
        public abstract void Lenght();

    }
}
