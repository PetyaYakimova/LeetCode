namespace _4Sum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int target = int.Parse(Console.ReadLine());

			IList<IList<int>> result = Solution.FourSum(nums, target);
			foreach (IList<int> set in result)
			{
				Console.WriteLine(String.Join(", ", set));
			}
		}
	}

	public static class Solution
	{
		public static IList<IList<int>> FourSum(int[] nums, int target)
		{
			nums = nums.OrderBy(x => x).ToArray();
			IList<IList<int>> result = new List<IList<int>>();

			for (int a = 0; a < nums.Length - 3; a++)
			{
				if (a > 0 && nums[a] == nums[a - 1])
				{
					continue;
				}
				for (int b = a + 1; b < nums.Length - 2; b++)
				{
					if (b > a + 1 && nums[b] == nums[b - 1])
					{
						continue;
					}
					for (int c = b + 1; c < nums.Length - 1; c++)
					{
						if (c > b + 1 && nums[c] == nums[c - 1])
						{
							continue;
						}
						if (nums.Skip(c + 1).Any(n => n == target - nums[a] - nums[b] - nums[c]))
						{
							int finalNumber = nums.Skip(c).FirstOrDefault(n => n == target - nums[a] - nums[b] - nums[c]);
							List<int> validResult = new List<int>() { nums[a], nums[b], nums[c], finalNumber };
							result.Add(validResult);
						}
					}
				}
			}

			return result;
		}
	}
}