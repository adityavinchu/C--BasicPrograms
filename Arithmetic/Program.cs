using System;

public class Arithmetic
{
    public void Main()
    {
        int num1, num2,choice;
        bool flag=true;

        while(flag)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine("Press 5 for Exit");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter your Choice");

            Console.WriteLine("\n");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 5)
                flag = false;
            else
            {
                Console.WriteLine("Enter 1st Number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter 2nd Number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition: {0}", num1 + num2);
                        break;
                    case 2:
                        Console.WriteLine("Subtraction: {0}", num1 - num2);
                        break;
                    case 3:
                        Console.WriteLine("Multiplication: {0}", num1 * num2);
                        break;
                    case 4:
                        Console.WriteLine("Division: {0}", num1 / num2);
                        break;
                    default:
                        Console.WriteLine("Enter correct Option");
                        break;
                }
            }
            Console.WriteLine("\n");
        }
    }
}

