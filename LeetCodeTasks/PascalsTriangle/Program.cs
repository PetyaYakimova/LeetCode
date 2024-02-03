namespace PascalsTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numRows = int.Parse(Console.ReadLine());

            IList<IList<int>> result = Solution.Generate(numRows);

            foreach (IList<int> line in result)
            {
                Console.WriteLine(string.Join(',', line));
            }
        }
    }

    public static class Solution
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            List<int> lastRow = new List<int>() { 1 };
            result.Add(lastRow);
            for (int row = 2; row <= numRows; row++)
            {
                List<int> currentRow = new List<int>();

                currentRow.Add(1);

                for (int i = 0; i < row - 2; i++)
                {
                    currentRow.Add(lastRow[i] + lastRow[i + 1]);
                }

                currentRow.Add(1);
                result.Add(currentRow);
                lastRow = currentRow;
            }

            return result;
        }
    }
}