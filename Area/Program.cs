using System;

public class Area
{
    public void Main()
    {
        int choice;
        bool flag = true;

        while (flag)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Press 1 for Rectangle");
            Console.WriteLine("Press 2 for Circle");
            Console.WriteLine("Press 3 for Triangle");
            Console.WriteLine("Press 4 for Exit");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter your Choice");

            Console.WriteLine("\n");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Rect rec=new Rect();
                    rec.areaOfRectangle();
                    break;
                case 2:
                    Circle circle=new Circle();
                    circle.areaOfCircle();
                    break;

                case 3:
                    Triangle triangle=new Triangle();
                    triangle.areaOfTriangle();
                    break;

                case 4:
                    flag = false;
                    break;

                default:
                    Console.WriteLine("Enter correct Option");
                    break;
            }
            Console.WriteLine("\n");
        }
    }
}
