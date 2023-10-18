

class Program
{

    static void Main()
    {
        Vector3d v1 = new(3, 4, 0);
        Console.WriteLine(v1);
        Vector3d v0 = new();
        Vector3d v2 = new(-1, 4, 2);
        Console.WriteLine(v1.GetLength());
        Console.WriteLine(v1.Length);
        Vector3d v3 = new(v2);
        Console.WriteLine( v3);
        Vector3d v4 = Vector3d.Add(v1, v2);
        Console.WriteLine(v4);
        Vector3d v5 = v1 + v2;
        Console.WriteLine(v5);
        //Console.WriteLine(v5[7]);
        v1.Normalize();
        Console.WriteLine(v1);
        v3[1] = 6;
        double dot = v1 * v2;
        Vector3d v6 = 3 * v1;
        Console.WriteLine(v6);
        Console.WriteLine(v3);
    }
}