using System.Text;

namespace IntegerToRoman
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			Console.WriteLine(Solution.IntToRoman(num));
		}
	}

	public static class Solution
	{
		public static string IntToRoman(int num)
		{
			StringBuilder sb = new StringBuilder();
			int thousands = num / 1000;
			if (thousands > 0)
			{
				string thousandsRepresentation = new string('M', thousands);
				sb.Append(thousandsRepresentation);
			}

			num = num % 1000;
			int hundreds = num / 100;
			if (hundreds == 9)
			{
				sb.Append("CM");
			}
			else
			{
				if (hundreds >= 5)
				{
					sb.Append('D');
					hundreds = hundreds - 5;
				}

				if (hundreds == 4)
				{
					sb.Append("CD");
				}
				else if (hundreds > 0)
				{
					string hundredsRepresentation = new string('C', hundreds);
					sb.Append(hundredsRepresentation);
				}
			}

			num = num % 100;
			int decimals = num / 10;
			if (decimals == 9)
			{
				sb.Append("XC");
			}
			else
			{
				if (decimals >= 5)
				{
					sb.Append('L');
					decimals = decimals - 5;
				}

				if (decimals == 4)
				{
					sb.Append("XL");
				}
				else if (decimals > 0)
				{
					string decimalsRepresentation = new string('X', decimals);
					sb.Append(decimalsRepresentation);
				}
			}

			num = num % 10;
			if (num == 9)
			{
				sb.Append("IX");
			}
			else
			{
				if (num >= 5)
				{
					sb.Append('V');
					num = num - 5;
				}

				if (num == 4)
				{
					sb.Append("IV");
				}
				else if (num > 0)
				{
					string digitsRepresentation = new string('I', num);
					sb.Append(digitsRepresentation);
				}
			}

			return sb.ToString();
		}
	}
}