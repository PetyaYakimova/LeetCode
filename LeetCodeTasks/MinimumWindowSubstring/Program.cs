namespace MinimumWindowSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();

            Console.WriteLine(Solution.MinWindow(s, t));
        }
    }

    public static class Solution
    {
        public static string MinWindow(string s, string t)
        {
            string result = "";
            for (int i = 0; i < s.Length - t.Length + 1; i++)
            {
                for (int j = t.Length; j < s.Length - i + 1; j++)
                {
                    if (result.Length != 0 && result.Length < j)
                    {
                        break;
                    }

                    string substring = s.Substring(i, j);
                    List<char> substringChars = substring.ToCharArray().ToList();
                    List<char> wantedChars = t.ToCharArray().ToList();
                    bool isContaining = true;

                    for (int k = wantedChars.Count - 1; k >= 0; k--)
                    {
                        if (substringChars.Count == 0)
                        {
                            isContaining = false;
                            break;
                        }
                        if (substringChars.Contains(wantedChars[k]))
                        {
                            substringChars.Remove(wantedChars[k]);
                            wantedChars.RemoveAt(k);
                        }
                        else
                        {
                            isContaining = false;
                            break;
                        }
                    }

                    if (wantedChars.Count > 0)
                    {
                        isContaining = false;
                    }

                    if (isContaining && (result.Length == 0 || result.Length > substring.Length))
                    {
                        result = substring;
                        break;
                    }
                }
            }

            return result;
        }
    }
}