using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapyear

public class Leap
{
	public void LeapYear()
	{
		Console.WriteLine("Enter Year");
		string input = Console.ReadLine();
		if (input.Length != 4)
		{
			Console.WriteLine("Invalid year ");
		}
		else
		{
			int Year = Convert.ToInt32(input);
			if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
			{
				Console.WriteLine("{0} is a Leap Year.", Year);
			}
			else
			{
				Console.WriteLine("{0} is NOT a Leap Year.", Year);
			}
		}
	}
}
