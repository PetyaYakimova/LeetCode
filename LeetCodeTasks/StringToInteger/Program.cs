using System.Text;

namespace StringToInteger
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string s = Console.ReadLine();
			Console.WriteLine(Solution.MyAtoi(s));
		}
	}

	public static class Solution
	{
		public static int MyAtoi(string s)
		{
			string clearedString = s.TrimStart(' ');
			bool isNegative = false;
			if (clearedString.Length > 0)
			{
				if (clearedString[0] == '-')
				{
					isNegative = true;
					clearedString = clearedString.Substring(1);
				}
				else if (clearedString[0] == '+')
				{
					clearedString = clearedString.Substring(1);
				}
			}

			StringBuilder onlyDigits = new StringBuilder();

			while (clearedString.Length > 0)
			{
				if (char.IsDigit(clearedString[0]))
				{
					onlyDigits.Append(clearedString[0]);
					clearedString = clearedString.Substring(1);
				}
				else
				{
					break;
				}
			}

			string digitsString = onlyDigits.ToString();

			if (digitsString.Length == 0)
			{
				return 0;
			}

			if (isNegative)
			{
				digitsString = "-" + digitsString;
			}

			int result = 0;
			if (int.TryParse(digitsString, out result))
			{
				result = int.Parse(digitsString);
			}
			else if (isNegative)
			{
				result = int.MinValue;
			}
			else
			{
				result = int.MaxValue;
			}

			return result;
		}
	}
}