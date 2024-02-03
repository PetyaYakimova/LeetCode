namespace MergeSortedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int m = int.Parse(Console.ReadLine());
            int[] nums2 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            Solution.Merge(nums1, m, nums2, n);
            Console.WriteLine(String.Join(',', nums1));
        }
    }

    public static class Solution
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int nums1Index = m - 1;
            int nums2Index = n - 1;
            int finalIndex = m + n - 1;

            while (finalIndex >= 0)
            {
                if (nums1Index < 0)
                {
                    nums1[finalIndex] = nums2[nums2Index];
                    nums2Index--;
                }
                else if (nums2Index < 0 || nums1[nums1Index] >= nums2[nums2Index])
                {
                    nums1[finalIndex] = nums1[nums1Index];
                    nums1Index--;
                }
                else
                {
                    nums1[finalIndex] = nums2[nums2Index];
                    nums2Index--;
                }
                finalIndex--;
            }
        }
    }
}