namespace SearchInsertPosition
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
			int target = int.Parse(Console.ReadLine());

			Console.WriteLine(Solution.SearchInsert(nums, target));
		}
	}

	public static class Solution
	{
		public static int SearchInsert(int[] nums, int target)
		{
			int index = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] > target)
				{
					break;
				}
				else if (nums[i] == target)
				{
					index = i;
					break;
				}
				else
				{
					index++;
				}
			}

			return index;
		}
	}
}