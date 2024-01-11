namespace _3Sum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			IList<IList<int>> result = Solution.ThreeSum(inputNumbers);

			foreach (IList<int> set in result)
			{
				Console.WriteLine(String.Join(' ', set));
			}
		}
	}

	public static class Solution
	{
		public static IList<IList<int>> ThreeSum(int[] nums)
		{
			IList<IList<int>> results = new List<IList<int>>();

			for (int i = 0; i < nums.Length - 2; i++)
			{
				for (int j = i + 1; j < nums.Length - 1; j++)
				{
					for (int k = j + 1; k < nums.Length; k++)
					{
						if (nums[i] + nums[j] + nums[k] == 0)
						{
							List<int> validOption = new List<int>() { nums[i], nums[j], nums[k] };
							if (results.Any(l => !l.Except(validOption).Any() && !validOption.Except(l).Any()))
							{
								continue;
							}

							results.Add(validOption);
						}
					}
				}
			}

			return results;
		}
	}
}