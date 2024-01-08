using System.Text;

namespace ZigZagConversion
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string inputString = Console.ReadLine();
			int numRows = int.Parse(Console.ReadLine());

			Console.WriteLine(Solution.Convert(inputString, numRows));

		}
	}

	public static class Solution
	{
		public static string Convert(string s, int numRows)
		{
			//Save the result as char matrix
			char[,] matrix = new char[numRows, s.Length];
			int currentIndex = 0;
			for (int col = 0; col < s.Length; col++)
			{
				//Every column with even index will be a column that is full with letters
				if (col % 2 == 0 || numRows == 1)
				{
					for (int row = 0; row < numRows; row++)
					{
						matrix[row, col] = s[currentIndex];
						currentIndex++;
						if (currentIndex == s.Length)
						{
							break;
						}
					}
				}
				//Every other column will represent the diagonals going to the next column full with letters
				else
				{
					for (int row = numRows - 2; row >= 1; row--)
					{
						matrix[row, col] = s[currentIndex];
						currentIndex++;
						if (currentIndex == s.Length)
						{
							break;
						}
					}
				}
				if (currentIndex == s.Length)
				{
					break;
				}
			}

			//Get the result as string
			StringBuilder result = new StringBuilder();
			for (int row = 0; row < numRows; row++)
			{
				for (int col = 0; col < s.Length; col++)
				{
					if (matrix[row, col] != 0)
					{
						result.Append(matrix[row, col]);
					}
				}
			}

			return result.ToString();
		}
	}
}