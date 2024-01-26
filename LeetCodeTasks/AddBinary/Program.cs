using System.Text;

namespace AddBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            Console.WriteLine(Solution.AddBinary(a, b));
        }
    }

    public static class Solution
    {
        public static string AddBinary(string a, string b)
        {
            Stack<string> result = new Stack<string>();

            int minLenghtBetweenTheTwoStrings = Math.Min(a.Length, b.Length);
            List<char> longerAsList = new List<char>();
            List<char> shorterAsList = new List<char>();
            if (a.Length >= b.Length)
            {
                longerAsList = a.ToCharArray().Reverse().ToList();
                shorterAsList = b.ToCharArray().Reverse().ToList();
            }
            else
            {
                longerAsList = b.ToCharArray().Reverse().ToList();
                shorterAsList = a.ToCharArray().Reverse().ToList();
            }

            int hasOneToTransfer = 0;
            for (int i = 0; i < minLenghtBetweenTheTwoStrings; i++)
            {
                int currentNumber = longerAsList[i] - '0' + (shorterAsList[i] - '0') + hasOneToTransfer;
                if (currentNumber > 1)
                {
                    hasOneToTransfer = 1;
                    currentNumber -= 2;
                }
                else
                {
                    hasOneToTransfer = 0;
                }

                result.Push(currentNumber.ToString());
            }

            for (int i = minLenghtBetweenTheTwoStrings; i < longerAsList.Count; i++)
            {
                int currentNumber = longerAsList[i] - '0' + hasOneToTransfer;
                if (currentNumber > 1)
                {
                    hasOneToTransfer = 1;
                    currentNumber -= 2;
                }
                else
                {
                    hasOneToTransfer = 0;
                }

                result.Push(currentNumber.ToString());
            }

            if (hasOneToTransfer > 0)
            {
                result.Push(hasOneToTransfer.ToString());
            }



            StringBuilder sb = new StringBuilder();
            while (result.Any())
            {
                sb.Append(result.Pop());
            }

            return sb.ToString();
        }
    }
}