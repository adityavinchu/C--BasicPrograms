using System;

public class Triangle
{
    float b, h;
    public areaOfTriangle()
	{
        Console.WriteLine("Enter Base: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Height: ");
        h = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Area of Rectangle: {0}", 0.5 * b * h);
    }
}
