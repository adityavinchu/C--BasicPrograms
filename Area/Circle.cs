using System;

namespace BasicCoreProg
{ 
	public class Circle
	{
		float radius;
		public areaOfCircle()
		{

			Console.WriteLine("Enter Radius: ");
			radius = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Area of circle: {0}", 3.14 * radius * radius);
		}
	}
}