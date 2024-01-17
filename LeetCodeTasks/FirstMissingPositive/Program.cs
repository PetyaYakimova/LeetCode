namespace FirstMissingPositive
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
			Console.WriteLine(Solution.FirstMissingPositive(nums));
		}
	}

	public static class Solution
	{
		public static int FirstMissingPositive(int[] nums)
		{
			for (int i = 1; i < int.MaxValue; i++)
			{
				if (!nums.Any(n => n == i))
				{
					return i;
				}
			}

			return int.MaxValue;
		}
	}
}