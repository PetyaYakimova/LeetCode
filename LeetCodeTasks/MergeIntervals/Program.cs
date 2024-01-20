namespace MergeIntervals
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numberOfIntervals = int.Parse(Console.ReadLine());
			int[][] intervals = new int[numberOfIntervals][];
			for (int i = 0; i < numberOfIntervals; i++)
			{
				intervals[i] = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
			}

			int[][] result = Solution.Merge(intervals);
			for (int i = 0; i < result.Length; i++)
			{
				Console.WriteLine(String.Join(",", result[i]));
			}
		}
	}

	public static class Solution
	{
		public static int[][] Merge(int[][] intervals)
		{
			List<int[]> result = new List<int[]>();
			result.Add(intervals[0]);
			for (int i = 1; i < intervals.Length; i++)
			{
				bool isMerged = false;
				for (int j = 0; j < result.Count; j++)
				{
					if (intervals[i][0] <= result[j][1] && intervals[i][1] >= result[j][0])
					{
						result[j][1] = Math.Max(result[j][1], intervals[i][1]);
						result[j][0] = Math.Min(result[j][0], intervals[i][0]);
						isMerged = true;
						break;
					}
					else if (intervals[i][1] >= result[j][0] && intervals[i][0] <= result[j][1])
					{
						result[j][1] = Math.Max(result[j][1], intervals[i][1]);
						result[j][0] = Math.Min(result[j][0], intervals[i][0]);
						isMerged = true;
						break;
					}
				}

				if (!isMerged)
				{
					result.Add(intervals[i]);
				}
			}

			return result.ToArray();
		}
	}
}