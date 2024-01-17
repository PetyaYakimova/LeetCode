namespace ValidSudoku
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char[][] board = new char[9][];
			for (int i = 0; i < 9; i++)
			{
				char[] line = Console.ReadLine().ToCharArray();
				board[i] = line;
			}

			Console.WriteLine(Solution.IsValidSudoku(board));
		}
	}

	public static class Solution
	{
		public static bool IsValidSudoku(char[][] board)
		{
			// Check every line
			for (int row = 0; row < 9; row++)
			{
				List<char> lineNumbers = new List<char>();
				for (int col = 0; col < 9; col++)
				{
					if (board[row][col] != '.')
					{
						if (lineNumbers.Any(n => n == board[row][col]))
						{
							return false;
						}
						else
						{
							lineNumbers.Add(board[row][col]);
						}
					}
				}
			}

			// Check every column
			for (int col = 0; col < 9; col++)
			{
				List<char> columnNumbers = new List<char>();
				for (int row = 0; row < 9; row++)
				{
					if (board[row][col] != '.')
					{
						if (columnNumbers.Any(n => n == board[row][col]))
						{
							return false;
						}
						else
						{
							columnNumbers.Add(board[row][col]);
						}
					}
				}
			}

			//Check every 3x3 square
			for (int r = 0; r < 9; r += 3)
			{
				for (int c = 0; c < 9; c += 3)
				{
					List<char> squareNumbers = new List<char>();
					for (int row = r; row < r + 3; row++)
					{
						for (int col = c; col < c + 3; col++)
						{
							if (board[row][col] != '.')
							{
								if (squareNumbers.Any(n => n == board[row][col]))
								{
									return false;
								}
								else
								{
									squareNumbers.Add(board[row][col]);
								}
							}
						}
					}
				}
			}

			return true;
		}
	}
}