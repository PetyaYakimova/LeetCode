namespace PlusOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] digits = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            Console.WriteLine(String.Join(",", Solution.PlusOne(digits)));
        }
    }

    public static class Solution
    {
        public static int[] PlusOne(int[] digits)
        {
            Stack<int> result = new Stack<int>();
            bool has1ToAdd = true;
            for (int j = digits.Length - 1; j >= 0; j--)
            {
                if (has1ToAdd)
                {
                    if (digits[j] == 9)
                    {
                        result.Push(0);
                    }
                    else
                    {
                        result.Push(digits[j] + 1);
                        has1ToAdd = false;
                    }
                }
                else
                {
                    result.Push(digits[j]);
                }
            }

            if (has1ToAdd)
            {
                result.Push(1);
            }

            return result.ToArray();
        }
    }
}