namespace LongestConsecutiveSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(Solution.LongestConsecutive(nums));
        }
    }

    public static class Solution
    {
        public static int LongestConsecutive(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int[] orderedNums = nums.OrderBy(x => x).ToArray();

            List<List<int>> sequences = new List<List<int>>();
            sequences.Add(new List<int> { orderedNums[0] });
            for (int i = 1; i < orderedNums.Length; i++)
            {
                if (orderedNums[i] == orderedNums[i - 1] + 1)
                {
                    sequences[sequences.Count - 1].Add(orderedNums[i]);
                }
                else if (orderedNums[i] > orderedNums[i - 1] + 1)
                {
                    sequences.Add(new List<int> { orderedNums[i] });
                }
            }

            return sequences.OrderByDescending(s => s.Count).First().Count();
        }
    }
}