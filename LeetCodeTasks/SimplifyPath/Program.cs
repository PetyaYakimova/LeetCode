namespace SimplifyPath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            Console.WriteLine(Solution.SimplifyPath(path));
        }
    }

    public static class Solution
    {
        public static string SimplifyPath(string path)
        {
            List<string> parts = path.Split('/', StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < parts.Count(); i++)
            {
                if (parts[i] == ".")
                {
                    parts.RemoveAt(i);
                    i--;
                }
                else if (parts[i] == "..")
                {
                    if (i > 0)
                    {
                        parts.RemoveAt(i);
                        parts.RemoveAt(i - 1);
                        i -= 2;
                    }
                    else
                    {
                        parts.RemoveAt(i);
                        i--;
                    }
                }
            }

            return "/" + string.Join('/', parts);
        }
    }
}