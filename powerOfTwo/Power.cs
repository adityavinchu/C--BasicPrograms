using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powerOfTwo
{
    public class Power
    {
        public void Power2()
        {
            Console.WriteLine("Enter the Power\n");
            int power=Convert.ToInt32(Console.ReadLine());
            Int32 ans = 1;

            for (int i = 0; i < power; i++)
            {
                ans =ans*2;

            }
            if ((ans > 0) && (ans % 2) == 0)
            {
                Console.WriteLine("2 to the power {0} is: {1}",power, ans);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadLine();  
        }
    }
}

