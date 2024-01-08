namespace LongestPalindromicSubstring
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string s = Console.ReadLine();
			Console.WriteLine(Solution.LongestPalindrome(s));
		}
	}

	public static class Solution
	{
		public static string LongestPalindrome(string s)
		{
			int maxLenght = 0;
			int startIndex = 0;

			for (int i = 0; i < s.Length; i++)
			{
				for (int max = s.Length - i; max > 0; max--)
				{
					if (IsPalindrome(s.Substring(i, max)))
					{
						if (maxLenght < max)
						{
							maxLenght = max;
							startIndex = i;
							break;
						}
					}
				}

				// No future palindrome will be able to beat this length, so no need to keep checking
				if (maxLenght > s.Length - i)
				{
					break;
				}
			}

			return s.Substring(startIndex, maxLenght);
		}

		public static bool IsPalindrome(string text)
		{
			for (int i = 0; i < text.Length / 2; i++)
			{
				if (text[i] != text[text.Length - i - 1])
				{
					return false;
				}
			}

			return true;
		}
	}
}