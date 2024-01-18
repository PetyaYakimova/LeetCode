namespace MaximumSubarray
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

			Console.WriteLine(Solution.MaxSubArray(nums));
		}
	}

	public static class Solution
	{
		public static int MaxSubArray(int[] nums)
		{
			int maxSum = nums[0];
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = 1; j <= nums.Length - i; j++)
				{
					int currentSum = nums.Skip(i).Take(j).Sum();
					if (currentSum > maxSum)
					{
						maxSum = currentSum;
					}
				}
			}

			return maxSum;
		}
	}
}