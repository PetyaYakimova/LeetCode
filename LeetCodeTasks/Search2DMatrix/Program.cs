namespace Search2DMatrix
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

            int target = int.Parse(Console.ReadLine());

            Console.WriteLine(Solution.SearchMatrix(matrix, target));
        }
    }

    public static class Solution
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int rows = matrix.Length;

            int firstRowPossible = 0;
            int lastPossibleRow = rows - 1;

            while (firstRowPossible != lastPossibleRow)
            {
                int mediumRow = firstRowPossible + lastPossibleRow / 2;
                if (matrix[mediumRow][0] > target)
                {
                    lastPossibleRow = mediumRow - 1;
                }
                else if (matrix[mediumRow][1] < target)
                {
                    firstRowPossible = mediumRow + 1;
                }
                else if (matrix[mediumRow][0] <= target)
                {
                    firstRowPossible = mediumRow;
                }
                else if (matrix[mediumRow][1] >= target)
                {
                    lastPossibleRow = mediumRow;
                }

                if (firstRowPossible > lastPossibleRow || firstRowPossible >= rows || lastPossibleRow < 0)
                {
                    return false;
                }

                if (matrix[mediumRow].Any(n=>n==target))
                {
                    return true;
                }
            }

            if (matrix[firstRowPossible].Any(n => n == target))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}