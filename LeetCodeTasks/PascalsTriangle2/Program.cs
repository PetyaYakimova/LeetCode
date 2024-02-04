namespace PascalsTriangle2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowIndex = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(',', Solution.GetRow(rowIndex)));
        }
    }

    public static class Solution
    {
        public static IList<int> GetRow(int rowIndex)
        {
            List<int> lastRow = new List<int>() { 1 };

            for (int row = 1; row <= rowIndex; row++)
            {
                List<int> currentRow = new List<int>();

                currentRow.Add(1);

                for (int i = 0; i < row - 1; i++)
                {
                    currentRow.Add(lastRow[i] + lastRow[i + 1]);
                }

                currentRow.Add(1);

                lastRow = currentRow;
            }

            return lastRow;
        }
    }
}