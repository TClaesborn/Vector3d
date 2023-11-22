using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

class Line
{
    Point3d p1;
    Point3d p2;

    public double Length
    {
        get
        {
            return GetLength();
        }
    }

    public Line(Point3d p1, Point3d p2)
    {
        this.p1 = p1;
        this.p2 = p2;
    }

    //Linear interpoloation
    Point3d Lerp(double t)
    {
        //Kolla så att t ligger mellan 0 och 1
        t = Math.Max(0, Math.Min(1, t));
        //Beräkna punkt
        double newX = p1.X + t * (p2.X - p1.X);
        double newY = p1.Y + t * (p2.Y - p1.Y);
        double newZ = p1.Z + t * (p2.Z - p1.Z);

        return new Point3d(newX, newY, newZ);
    }

    public void Draw(char sign, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        for (double t = 0; t <= 1; t += 0.01)
        {
            Point3d interpolatedPoint = Lerp(t);
            int consoleX = (int)interpolatedPoint.X;
            int consoleY = (int)interpolatedPoint.Y;
            Console.SetCursorPosition(consoleX, consoleY);
            Console.Write(sign);
        }
        Console.ResetColor();
    }

    public double GetLength()
    {
        double dx = p2.X - p1.X;
        double dy = p2.Y - p1.Y;
        double dz = p2.Z - p1.Z;

        return Math.Sqrt(dx * dx + dy * dy + dz * dz);

    }

    public override string ToString()
    {
        return $"{p1} - {p2}";
    }
}

