namespace SearchInRotatedSortedArray2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine(Solution.Search(nums, target));
        }
    }

    public static class Solution
    {
        public static bool Search(int[] nums, int target)
        {
            int minPossibleIndex = 0;
            int maxPossibleIndex = nums.Length - 1;
            int indexOfMinValue = Array.IndexOf(nums, nums.Min());

            while (minPossibleIndex < maxPossibleIndex)
            {
                if (nums[minPossibleIndex] == target || nums[maxPossibleIndex] == target)
                {
                    return true;
                }

                if (nums[minPossibleIndex] < target)
                {
                    minPossibleIndex++;
                    if (minPossibleIndex >= nums.Length)
                    {
                        return false;
                    }
                }
                else if (nums[minPossibleIndex] > target)
                {
                    minPossibleIndex = indexOfMinValue;
                }

                if (nums[maxPossibleIndex] > target)
                {
                    maxPossibleIndex--;
                    if (minPossibleIndex < 0)
                    {
                        return false;
                    }
                }
                else if (nums[maxPossibleIndex] < target)
                {
                    maxPossibleIndex = indexOfMinValue - 1 >= 0 ? indexOfMinValue - 1 : 0;
                }
            }

            if (nums[minPossibleIndex] == target)
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