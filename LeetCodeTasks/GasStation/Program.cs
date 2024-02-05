namespace GasStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] gas = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] cost = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(Solution.CanCompleteCircuit(gas, cost));
        }
    }

    public static class Solution
    {
        public static int CanCompleteCircuit(int[] gas, int[] cost)
        {
            if (gas.Sum() < cost.Sum())
            {
                return -1;
            }

            for (int startingIndex = 0; startingIndex < gas.Length; startingIndex++)
            {
                int currentGas = 0;
                bool isPossible = true;
                for (int laps = 0; laps < gas.Length; laps++)
                {
                    int stationNumber = (startingIndex + laps) < gas.Length ? (startingIndex + laps) : (startingIndex + laps) - gas.Length;
                    currentGas += (gas[stationNumber] - cost[stationNumber]);
                    if (currentGas < 0)
                    {
                        isPossible = false;
                        break;
                    }
                }

                if (isPossible)
                {
                    return startingIndex;
                }
            }

            return -1;
        }
    }
}