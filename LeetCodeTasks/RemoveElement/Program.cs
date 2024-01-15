namespace RemoveElement
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
			int val = int.Parse(Console.ReadLine());

			Console.WriteLine(Solution.RemoveElement(nums, val));
		}
	}

	public static class Solution
	{
		public static int RemoveElement(int[] nums, int val)
		{
			int totalCount = nums.Where(n=>n!=val).Count();

			if (totalCount > 0)
			{
				int currentIndex = 0;
				for (int i = 0; i < nums.Length; i++)
				{
					if (nums[currentIndex] == val)
					{
						for (int j = currentIndex; j < nums.Length - 1; j++)
						{
							nums[j] = nums[j + 1];
						}
						nums[nums.Length - 1] = val;
					}
					else
					{
						currentIndex++;
					}
				}
			}

			return totalCount;
		}
	}
}