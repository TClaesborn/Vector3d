

using System.Numerics;

class Program
{

    static void Main()
    {
        Point3d p1 = new(10, 2, 3);
        Point3d p2 = new(25, 29, -3);
        Line l1 = new(p1, p2);
        Console.WriteLine(l1);
        l1.Draw('#', ConsoleColor.Blue);
    }
}