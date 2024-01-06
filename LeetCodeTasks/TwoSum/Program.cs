namespace TwoSum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int target = int.Parse(Console.ReadLine());
			int[] result = Solution.TwoSum(inputNums, target);
			Console.WriteLine(string.Join(' ', result));
		}
	}

	internal static class Solution
	{
		public static int[] TwoSum(int[] nums, int target)
		{
			for (int i = 0; i < nums.Length - 1; i++)
			{
				int remaining = target - nums[i];
				int j = Array.IndexOf(nums, remaining, i + 1);
				if (j > 0)
				{
					return new int[] { i, j };
				}
			}

			return new int[] { -1, -1 };
		}
	}
}