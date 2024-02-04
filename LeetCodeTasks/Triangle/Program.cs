namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            IList<IList<int>> triangle = new List<IList<int>>();
            for (int i = 0; i < height; i++)
            {
                triangle.Add(Console.ReadLine().Split(',').Select(int.Parse).ToList());
            }

            Console.WriteLine(Solution.MinimumTotal(triangle));
        }
    }

    public static class Solution
    {
        public static int MinimumTotal(IList<IList<int>> triangle)
        {
            if (triangle == null || triangle.Count == 0)
            {
                return 0;
            }

            for (int row = triangle.Count - 2; row >= 0; row--)
            {
                for (int col = 0; col < triangle[row].Count; col++)
                {
                    triangle[row][col] += Math.Min(triangle[row + 1][col], triangle[row + 1][col + 1]);
                }
            }

            return triangle[0][0];
        }
    }
}