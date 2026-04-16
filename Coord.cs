using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZludovaPractica
{
    public readonly struct Coord
    {
        public int X { get; }
        public int Y { get; }


        public Coord(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Coord operator +(Coord a, Coord b) => new(a.X + b.X, a.Y + b.Y);
        public static Coord operator -(Coord a, Coord b) => new(a.X - b.X, a.Y - b.Y);
        public static Coord operator *(Coord a, int b) => new(a.X * b, a.Y * b);
        public static bool operator ==(Coord a, Coord b) => a.Equals(b);
        public static bool operator !=(Coord a, Coord b) => !a.Equals(b);

        public override bool Equals(object? obj)
        {
            if (obj is Coord other)
            {
                return X == other.X && Y == other.Y;
            }
            return false;
        }

        public override int GetHashCode() => HashCode.Combine(X, Y);    
    }

    
}
