using System;

public class Rect
{
    float len, wid;
    public areaOfRectangle()
	{
        Console.WriteLine("Enter Length: ");
        len = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Width: ");
        wid = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Area of rectangle: {0}", len * wid);
    }
}
