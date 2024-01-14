namespace CountElementsWithMaxximumFrequency
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
			Console.WriteLine(Solution.MaxFrequencyElements(nums));
		}
	}

	public static class Solution
	{
		public static int MaxFrequencyElements(int[] nums)
		{
			int maxFrequency = 1;

			nums = nums.OrderBy(n => n).ToArray();
			int currentElement = nums[0];
			int currentFrequency = 1;
			List<int> maxFrequencyElements = new List<int>();
			maxFrequencyElements.Add(currentElement);

			for (int i = 1; i < nums.Length; i++)
			{
				if (nums[i] == currentElement)
				{
					currentFrequency++;
				}
				else
				{
					currentFrequency = 1;
					currentElement = nums[i];
				}

				if (currentFrequency == maxFrequency)
				{
					for (int j = 0; j < maxFrequency; j++)
					{
						maxFrequencyElements.Add(currentElement);
					}
				}
				else if (currentFrequency > maxFrequency)
				{
					maxFrequency = currentFrequency;
					maxFrequencyElements.Clear();
					for (int j = 0; j < maxFrequency; j++)
					{
						maxFrequencyElements.Add(currentElement);
					}
				}
			}

			return maxFrequencyElements.Count;
		}
	}
}