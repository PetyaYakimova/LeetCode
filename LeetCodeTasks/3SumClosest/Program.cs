namespace _3SumClosest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int target = int.Parse(Console.ReadLine());

			Console.WriteLine(Solution.ThreeSumClosest(nums, target));
		}
	}

	public static class Solution
	{
		public static int ThreeSumClosest(int[] nums, int target)
		{
			int closestSum = nums[0] + nums[1] + nums[2];
			int minDifference = Math.Abs(closestSum - target);

			for (int i = 0; i < nums.Length - 2; i++)
			{
				for (int j = i + 1; j < nums.Length - 1; j++)
				{
					for (int k = j + 1; k < nums.Length; k++)
					{
						int currentSum = nums[i] + nums[j] + nums[k];
						int currentDifference = Math.Abs(currentSum - target);
						if (currentDifference < minDifference)
						{
							minDifference = currentDifference;
							closestSum = currentSum;
						}
					}
				}
			}

			return closestSum;
		}
	}
}