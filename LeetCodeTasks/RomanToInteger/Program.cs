namespace RomanToInteger
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string s = Console.ReadLine(); ;
			Console.WriteLine(Solution.RomanToInt(s));
		}
	}

	public static class Solution
	{
		public static int RomanToInt(string s)
		{
			int finalNumber = 0;
			while (s.StartsWith('M'))
			{
				finalNumber += 1000;
				s = s.Substring(1);
			}

			if (s.StartsWith("CM"))
			{
				finalNumber += 900;
				s = s.Substring(2);
			}
			if (s.StartsWith("CD"))
			{
				finalNumber += 400;
				s = s.Substring(2);
			}
			if (s.StartsWith('D'))
			{
				finalNumber += 500;
				s = s.Substring(1);
			}
			while (s.StartsWith('C'))
			{
				finalNumber += 100;
				s = s.Substring(1);
			}

			if (s.StartsWith("XC"))
			{
				finalNumber += 90;
				s = s.Substring(2);
			}
			if (s.StartsWith("XL"))
			{
				finalNumber += 40;
				s = s.Substring(2);
			}
			if (s.StartsWith('L'))
			{
				finalNumber += 50;
				s = s.Substring(1);
			}
			while (s.StartsWith('X'))
			{
				finalNumber += 10;
				s = s.Substring(1);
			}

			if (s.StartsWith("IX"))
			{
				finalNumber += 9;
				s = s.Substring(2);
			}
			if (s.StartsWith("IV"))
			{
				finalNumber += 4;
				s = s.Substring(2);
			}
			if (s.StartsWith('V'))
			{
				finalNumber += 5;
				s = s.Substring(1);
			}
			while (s.StartsWith('I'))
			{
				finalNumber += 1;
				s = s.Substring(1);
			}

			return finalNumber;
		}
	}
}