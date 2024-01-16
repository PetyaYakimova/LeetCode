using System.Runtime.CompilerServices;

namespace LongestValidParentheses
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string s = Console.ReadLine();
			Console.WriteLine(Solution.LongestValidParentheses(s));
		}
	}

	public static class Solution
	{
		public static int LongestValidParentheses(string s)
		{
			int longestValid = 0;
			for (int i = 0; i < s.Length - 1; i++)
			{
				for (int j = s.Length - i; j > longestValid; j--)
				{
					string substring = s.Substring(i, j);
					if (IsValid(substring))
					{
						longestValid = j;
					}
				}
			}

			return longestValid;
		}

		public static bool IsValid(string s)
		{
			if (s.Length <= 1 || s.Length % 2 != 0)
			{
				return false;
			}

			Stack<char> openingBrackets = new Stack<char>();
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == '(' || s[i] == '{' || s[i] == '[')
				{
					openingBrackets.Push(s[i]);
				}

				else if (openingBrackets.Count == 0)
				{
					return false;
				}

				else if (s[i] == ')')
				{
					if (openingBrackets.Peek() == '(')
					{
						openingBrackets.Pop();
					}
					else
					{
						return false;
					}
				}

				else if (s[i] == ']')
				{
					if (openingBrackets.Peek() == '[')
					{
						openingBrackets.Pop();
					}
					else
					{
						return false;
					}
				}

				else if (s[i] == '}')
				{
					if (openingBrackets.Peek() == '{')
					{
						openingBrackets.Pop();
					}
					else
					{
						return false;
					}
				}
			}

			if (openingBrackets.Count == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}