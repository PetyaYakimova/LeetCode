namespace ContainerWithMostWater
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			Console.WriteLine(Solution.MaxArea(inputNumbers));
		}
	}

	public static class Solution
	{
		public static int MaxArea(int[] height)
		{
			int maxArea = 0;
			int startPillarIndex = 0;
			int endPillarIndex = height.Length - 1;

			while (startPillarIndex < endPillarIndex)
			{
				int containerHeight = Math.Min(height[startPillarIndex], height[endPillarIndex]);
				int containerWidth = endPillarIndex - startPillarIndex;
				maxArea = Math.Max(maxArea, containerHeight * containerWidth);

				if (height[startPillarIndex] < height[endPillarIndex])
				{
					startPillarIndex++;
				}
				else
				{
					endPillarIndex--;
				}
			}
			return maxArea;
		}
	}
}