using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class Point3d
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public double this[int i]
    {
        get
        {
            return i switch
            {
                0 => this.X,
                1 => this.Y,
                2 => this.Z,
                _ => throw new IndexOutOfRangeException(),
            };
        }
    }

    public Point3d(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public Point3d(Point3d point)
    {
        X = point.X;
        Y = point.Y;
        Z = point.Z;
    }
    public Point3d(Point3d point, Vector3d vec)
    {
        X = point.X + vec.X;
        Y = point.Y + vec.Y;
        Z = point.Z + vec.Z;
    }
    public Point3d()
    {
        X = 0;
        Y = 0;
        Z = 0;
    }
    public void Move(Vector3d vec)
    {
        this.X += vec.X;
        this.Y += vec.Y;
        this.Z += vec.Z;
    }
    public void Move(double x, double y, double z)
    {
        X += x;
        Y += y;
        Z += z;
    }
    public void SetPosition(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }

    public static Point3d Add(Point3d p1, Point3d p2)
    {
        return new(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
    }

    public static Point3d operator +(Point3d p1, Point3d p2)
    {
        return Add(p1, p2);
    }
    public static Point3d operator +(Point3d p1, Vector3d vec)
    {
        return new(p1, vec);
    }
}

