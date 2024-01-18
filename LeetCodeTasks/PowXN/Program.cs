namespace PowXN
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double x = double.Parse(Console.ReadLine());
			int n = int.Parse(Console.ReadLine());

			Console.WriteLine(Solution.MyPow(x, n));
		}
	}

	public static class Solution
	{
		public static double MyPow(double x, int n)
		{
			double result = 1.00;

			if (n > 0)
			{
				for (int i = 1; i <= n; i++)
				{
					result *= x;
				}
			}
			else if (n < 0)
			{
				for (int i = 1; i <= n * (-1); i++)
				{
					result /= x;
				}
			}

			return result;
		}
	}
}