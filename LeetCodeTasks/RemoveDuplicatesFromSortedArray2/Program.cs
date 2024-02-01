namespace RemoveDuplicatesFromSortedArray2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            Console.WriteLine(Solution.RemoveDuplicates(nums));

            Console.WriteLine(string.Join(',', nums));
        }
    }

    public static class Solution
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int currentNumber = nums[0];
            int currentNumberCount = 1;
            int k = 1;
            int numberOfDuplicates = 0;

            for (int i = 1; i < nums.Length - numberOfDuplicates; i++)
            {
                if (nums[i] == currentNumber)
                {
                    if (currentNumberCount < 2)
                    {
                        currentNumberCount++;
                        k++;
                    }
                    else
                    {
                        for (int j = i; j < nums.Length - 1 - numberOfDuplicates; j++)
                        {
                            nums[j] = nums[j + 1];
                        }
                        nums[nums.Length - 1 - numberOfDuplicates] = int.MaxValue;
                        i--;
                        numberOfDuplicates++;
                    }
                }
                else
                {
                    currentNumber = nums[i];
                    currentNumberCount = 1;
                    k++;
                }
            }

            return k;
        }
    }
}