namespace LongestCommonPrefix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] inputStrings = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
			Console.WriteLine(Solution.LongestCommonPrefix(inputStrings));
		}
	}

	public static class Solution
	{
		public static string LongestCommonPrefix(string[] strs)
		{
			string shortestWord = strs.OrderBy(s => s.Length).FirstOrDefault();
			string longestPrefix = "";
			for (int i = 0; i < shortestWord.Length; i++)
			{
				longestPrefix = shortestWord.Substring(0, shortestWord.Length - i);
				if (strs.Any(s => !s.StartsWith(longestPrefix)))
				{
					continue;
				}
				else
				{
					return longestPrefix;
				}
			}

			return "";
		}
	}
}