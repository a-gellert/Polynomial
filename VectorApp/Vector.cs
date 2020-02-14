using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorApp
{
    public class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public static Vector operator +(Vector vectorA, Vector vectorB)
        {
            return new Vector { X = vectorA.X + vectorB.X, Y = vectorA.Y + vectorB.Y, Z = vectorA.Z + vectorB.Z };
        }
        public static Vector operator -(Vector vectorA, Vector vectorB)
        {
            return new Vector { X = vectorA.X - vectorB.X, Y = vectorA.Y - vectorB.Y, Z = vectorA.Z - vectorB.Z };
        }
        public static Vector operator +(Vector vectorA, int a)
        {
            return new Vector { X = vectorA.X + a, Y = vectorA.Y + a, Z = vectorA.Z + a };
        }
        public static Vector operator +(int a, Vector vectorA)
        {
            return new Vector { X = vectorA.X + a, Y = vectorA.Y + a, Z = vectorA.Z + a };
        }
        public static Vector operator -(Vector vectorA, int a)
        {
            return new Vector { X = vectorA.X - a, Y = vectorA.Y - a, Z = vectorA.Z - a };
        }
        public static Vector operator -(int a, Vector vectorA)
        {
            return new Vector { X = a - vectorA.X, Y = a - vectorA.Y, Z = a - vectorA.Z };
        }
        public static Vector operator *(Vector vectorA, int a)
        {
            return new Vector { X = vectorA.X * a, Y = vectorA.Y * a, Z = vectorA.Z * a };
        }
        public static Vector operator *(int a, Vector vectorA)
        {
            return new Vector { X = vectorA.X * a, Y = vectorA.Y * a, Z = vectorA.Z * a };
        }
        public static Vector operator /(Vector vectorA, int a)
        {
            return new Vector { X = vectorA.X / a, Y = vectorA.Y / a, Z = vectorA.Z / a };
        }
        public static bool operator ==(Vector vectorA, Vector vectorB)
        {
            return (vectorA.X == vectorB.X && vectorA.Y == vectorB.Y && vectorA.Z == vectorB.Z);
        }

        public static bool operator !=(Vector vectorA, Vector vectorB)
        {
            return (vectorA.X != vectorB.X || vectorA.Y == vectorB.Y || vectorA.Z == vectorB.Z);
        }
        public override string ToString()
        {
            return $"X = {X}, Y = {Y}, Z = {Z}";
        }
    }
}
