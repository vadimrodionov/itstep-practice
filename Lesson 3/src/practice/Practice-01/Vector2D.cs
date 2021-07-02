using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Practice_01
{
    class Vector2D:Vector
    {
        Vector2D(double x, double y)
        {
                _x = x;
                _y = y;
        }
        private double _x;
        private double _y;
        public override double AbsoluteValue => throw new NotImplementedException();
        public static Vector2D operator -(Vector2D vector) => new Vector2D(-vector._x,-vector._y);
        public static Vector2D operator +(Vector2D a, Vector2D b) => new Vector2D(a._x + b._x, a._y + b._y);
        public static Vector2D operator *(Vector2D v, double multuplier) => new Vector2D(v._x*multuplier,v._y*multuplier);
        public static Vector2D operator *(double multuplier, Vector2D v) => new Vector2D(v._x * multuplier, v._y * multuplier);
        public static Vector2D operator /(Vector2D v, double divider) => new Vector2D(v._x / divider, v._y / divider);
        public static Vector2D operator *(Vector2D a, Vector2D b) => throw new NotImplementedException();
        public override bool Equals(object obj) => obj is Vector2D v && v._x == _x && v._y == _y;
        public override int GetHashCode() => base.GetHashCode();
        public static bool operator == (Vector2D a, Vector2D b)=> a.Equals(b);
        public static bool operator !=(Vector2D a, Vector2D b) => !a.Equals(b);

        public override bool IsNormal()
        {
            throw new NotImplementedException();
        }
        public override void Lenght()
        {
            throw new NotImplementedException();
        }
    
    }
}
