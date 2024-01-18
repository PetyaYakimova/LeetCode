namespace SpiralMatrix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int m = int.Parse(Console.ReadLine());
			int[][] matrix = new int[m][];

			for (int i = 0; i < m; i++)
			{
				int[] currentRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				matrix[i] = currentRow;
			}

			Console.WriteLine(string.Join(", ", Solution.SpiralOrder(matrix)));
		}
	}

	public static class Solution
	{
		public static IList<int> SpiralOrder(int[][] matrix)
		{
			int m = matrix.Length;
			int n = matrix[0].Length;
			IList<int> result = new List<int>();

			//Will go through the matrix in circles as each circle goes through all 4 sides
			int circleNumber = 0;
			bool hasBeenIn = false;
			while (circleNumber < Math.Ceiling((double)m / 2))
			{
				for (int col = circleNumber; col < n - circleNumber; col++)
				{
					result.Add(matrix[circleNumber][col]);
					hasBeenIn = true;
				}
				if (!hasBeenIn)
				{
					break;
				}
				hasBeenIn = false;
				for (int row = circleNumber + 1; row < m - circleNumber; row++)
				{
					result.Add(matrix[row][n - 1 - circleNumber]);
					hasBeenIn = true;
				}
				if (!hasBeenIn)
				{
					break;
				}
				hasBeenIn = false;
				for (int col = n - circleNumber - 2; col >= circleNumber; col--)
				{
					result.Add(matrix[m - circleNumber - 1][col]);
					hasBeenIn = true;
				}
				if (!hasBeenIn)
				{
					break;
				}
				hasBeenIn = false;
				for (int row = m - circleNumber - 2; row > circleNumber; row--)
				{
					result.Add(matrix[row][circleNumber]);
				}
				circleNumber++;
			}

			return result;
		}
	}
}