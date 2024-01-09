namespace PalindromeNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			Console.WriteLine(Solution.IsPalindrome(number));
		}
	}

	public static class Solution
	{
		public static bool IsPalindrome(int x)
		{
			if (x < 0)
			{
				return false;
			}
			if (x == 0)
			{ 
				return true;
			}
			if (x % 10 == 0)
			{
				return false;
			}

			int numberOfDigits = 1;
			int copyNumber = x;
			while (copyNumber >= 10)
			{
				numberOfDigits++;
				copyNumber = copyNumber / 10;
			}

			for (int i = 0; i < numberOfDigits / 2; i++)
			{
				int lastDigit = x % 10;
				int powerOf10 = (int)(Math.Pow(10, numberOfDigits - i * 2 - 1));
				int firstDigit = x / powerOf10;
				if (lastDigit != firstDigit)
				{
					return false;
				}
				x = x % powerOf10;
				x = x / 10;
			}

			return true;
		}
	}
}