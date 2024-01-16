using System.Globalization;

namespace FindFirstAndLastPositionOFElementInSortedArray
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
			int target = int.Parse(Console.ReadLine());

			Console.WriteLine(string.Join(", ", Solution.SearchRange(nums, target)));
		}

	}

	public static class Solution
	{
		public static int[] SearchRange(int[] nums, int target)
		{
			int[] defaultResult = new int[2] { -1, -1 };

			if (nums.Length == 0 || nums[0] > target || nums[nums.Length - 1] < target)
			{
				return defaultResult;
			}

			int startIndex = -1;
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] > target)
				{
					return defaultResult;
				}
				if (nums[i] == target)
				{
					startIndex = i;
					break;
				}
			}

			int endIndex = startIndex;
			for (int i = startIndex + 1; i < nums.Length; i++)
			{
				if (nums[i] > target)
				{
					return new int[] { startIndex, endIndex };
				}
				else if (nums[i] == target)
				{
					endIndex = i;
				}
			}

			return new int[] { startIndex, endIndex };
		}
	}
}