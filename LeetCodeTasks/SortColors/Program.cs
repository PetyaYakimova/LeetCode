namespace SortColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            Solution.SortColors(nums);

            Console.WriteLine(string.Join(',', nums));
        }
    }

    public static class Solution
    {
        public static void SortColors(int[] nums)
        {
            for (int max = nums.Length - 1; max > 0; max--)
            {
                for (int i = 0; i < max; i++)
                {

                    if (nums[i] > nums[i + 1])
                    {
                        int temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                    }
                }
            }
        }
    }
}