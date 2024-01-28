namespace SqrtX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(Solution.MySqrt(x));
        }
    }

    public static class Solution
    {
        public static int MySqrt(int x)
        {
            if (x == 0)
            {
                return 0;
            }

            int maxNumber = 1;
            for (int i = 2; i < x; i++)
            {
                if (i * i == x)
                {
                    return i;
                }
                else if ((double)i * i > x)
                {
                    break;
                }
                else
                {
                    maxNumber = i;
                }
            }

            return maxNumber;
        }
    }
}