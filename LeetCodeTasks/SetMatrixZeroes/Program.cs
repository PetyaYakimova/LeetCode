using System.ComponentModel;

namespace SetMatrixZeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixRows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[matrixRows][];
            for (int i = 0; i < matrixRows; i++)
            {
                matrix[i] = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            }

            Solution.SetZeroes(matrix);

            for (int i = 0; i < matrixRows; i++)
            {
                Console.WriteLine(String.Join(',', matrix[i]));
            }
        }
    }

    public static class Solution
    {
        public static void SetZeroes(int[][] matrix)
        {
            int matrixRows = matrix.Length;
            int matrixCols = matrix[0].Length;

            //Find all zeros
            List<int[]> zeroesPositions = new List<int[]>();
            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    if (matrix[row][col] == 0)
                    {
                        zeroesPositions.Add(new int[] { row, col });
                    }
                }
            }

            //For every zero make every number on its row and column a zero
            foreach (int[] zeroPositions in zeroesPositions)
            {
                int row = zeroPositions[0];
                int col = zeroPositions[1];
                for (int i = 0; i < matrixCols; i++)
                {
                    matrix[row][i] = 0;
                }
                for (int j = 0; j < matrixRows; j++)
                {
                    matrix[j][col] = 0;
                }
            }
        }
    }
}