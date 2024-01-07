namespace LongestSubstringWithoutRepeatingCharacters
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string s = Console.ReadLine();
			Console.WriteLine(Solution.LengthOfLongestSubstring(s));
		}
	}

	public static class Solution
	{
		public static int LengthOfLongestSubstring(string s)
		{
			int maxLength = 0;

			for (int i = 0; i < s.Length; i++)
			{
				List<char> currentSequence = new List<char>();
				currentSequence.Add(s[i]);
				for (int j = i + 1; j < s.Length; j++)
				{
					if (currentSequence.Any(c => c == s[j]))
					{
						break;
					}

					currentSequence.Add(s[j]);
				}

				if (maxLength < currentSequence.Count)
				{
					maxLength = currentSequence.Count;
				}

				if (maxLength > s.Length - i)
				{
					break;
				}
			}

			return maxLength;
		}
	}
}