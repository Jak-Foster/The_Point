using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        Point PointOne = new Point(2, 3);
        Point PointTwo = new Point(-4, 0);
        Console.WriteLine($"Point 1: ({PointOne.X}, {PointOne.Y})");
        Console.WriteLine($"Point 2: ({PointTwo.X}, {PointTwo.Y})");
    }
}