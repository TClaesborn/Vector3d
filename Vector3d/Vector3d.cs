using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CA1050
public class Vector3d
{
#pragma warning restore CA1050
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public double Length
    {
        get
        {
            return GetLength();
        }
    }

    //Indexer
    public double this[int i]
    {
        get
        {
            return i switch
            {
                0 => X,
                1 => Y,
                2 => Z,
                _ => throw new IndexOutOfRangeException(),
            };
        }
        set
        {
            switch(i)
            {
                case 0:
                    X = value;
                    break;
                case 1:
                    Y = value;
                    break;
                case 2:
                    Z = value;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }

    //Constructor (Overloads)
    
    public Vector3d(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public Vector3d()
    {
        X = 0;
        Y = 0;
        Z = 0;
    }
    public Vector3d(Vector3d other)
    {
        X = other.X;
        Y = other.Y;
        Z = other.Z;
    }

    //Override (Polymorfi)
    public override string ToString()
    {
        return $"[{X}, {Y}, {Z}]";
    }

    //Methods/Functions
    public double GetLength()
    {
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }

    public static double Dot(Vector3d a, Vector3d b)
    {
        return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
    }

    public void Normalize()
    {
        double len = Length;
        X /= len;
        Y /= len;
        Z /= len;
    }

    public void Scale(double scaleFactor)
    {
        X *= scaleFactor;
        Y *= scaleFactor;
        Z *= scaleFactor;
    }

    public static Vector3d Add(Vector3d a, Vector3d b)
    {
        return new Vector3d(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }

    //Operators (overload)
    public static Vector3d operator +(Vector3d a, Vector3d b)
    {
        return Add(a, b);
    }
    public static double operator *(Vector3d a, Vector3d b)
    {
        return Dot(a, b);
    }
    public static Vector3d operator *(double a, Vector3d b)
    {
        return new Vector3d(a*b.X, a*b.Y, a*b.Z);
    }
    public static Vector3d operator *(Vector3d b, double a)
    {
        return new Vector3d(a * b.X, a * b.Y, a * b.Z);
    }
}

