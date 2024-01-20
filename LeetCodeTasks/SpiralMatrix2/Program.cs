namespace SpiralMatrix2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[][] result = Solution.GenerateMatrix(n);
			for (int i = 0; i < result.Length; i++)
			{
				Console.WriteLine(String.Join(" ", result[i]));
			}
		}
	}

	public static class Solution
	{
		public static int[][] GenerateMatrix(int n)
		{
			//Create the matrix
			int[][] result = new int[n][];
			for (int i = 0; i < n; i++)
			{
				result[i] = new int[n];
			}

			//Going in spirals by 4 sides
			int circleNumber = 0;
			int currentNumber = 1;
			int maxNumber = n * n;
			while (circleNumber < Math.Ceiling((double)n / 2))
			{
				if (currentNumber > maxNumber)
				{
					break;
				}
				for (int col = circleNumber; col < n - circleNumber; col++)
				{
					result[circleNumber][col] = currentNumber;
					currentNumber++;
				}
				if (currentNumber>maxNumber)
				{
					break;
				}
				for (int row = circleNumber + 1; row < n - circleNumber; row++)
				{
					result[row][n - 1 - circleNumber] = currentNumber;
					currentNumber++;
				}
				if (currentNumber > maxNumber)
				{
					break;
				}
				for (int col = n - circleNumber - 2; col >= circleNumber; col--)
				{
					result[n - circleNumber - 1][col] = currentNumber;
					currentNumber++;
				}
				if (currentNumber > maxNumber)
				{
					break;
				}
				for (int row = n - circleNumber - 2; row > circleNumber; row--)
				{
					result[row][circleNumber] = currentNumber;
					currentNumber++;
				}
				circleNumber++;
			}

			return result;
		}
	}
}