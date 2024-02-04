namespace BestTimeToBuyAndSellStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(Solution.MaxProfit(prices));
        }
    }

    public static class Solution
    {
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                int maxValue = prices.Skip(i + 1).Max();
                if (maxValue - prices[i] > maxProfit)
                {
                    maxProfit = maxValue- prices[i];
                }
            }

            return maxProfit;
        }
    }
}