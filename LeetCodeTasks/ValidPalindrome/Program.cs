namespace ValidPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            Console.WriteLine(Solution.IsPalindrome(s));
        }
    }

    public static class Solution
    {
        public static bool IsPalindrome(string s)
        {
            List<char> validLetters = new List<char>();
            foreach (char symbol in s.ToLower())
            {
                if (Char.IsLetter(symbol))
                {
                    validLetters.Add(symbol);
                }
            }

            for (int i = 0; i < validLetters.Count / 2; i++)
            {
                if (validLetters[i] != validLetters[validLetters.Count - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}