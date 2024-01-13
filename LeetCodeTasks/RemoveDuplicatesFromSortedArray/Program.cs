namespace RemoveDuplicatesFromSortedArray
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
			Console.WriteLine(Solution.RemoveDuplicates(nums));
		}
	}

	public static class Solution
	{
		public static int RemoveDuplicates(int[] nums)
		{
			int lastValue = nums[0];
			int k = 0;
			for (int i = 1; i < nums.Length; i++)
			{
				if (nums[i] != lastValue)
				{
					k++;
					lastValue = nums[i];
					nums[k] = lastValue;
				}
			}

			return k + 1;
		}
	}
}