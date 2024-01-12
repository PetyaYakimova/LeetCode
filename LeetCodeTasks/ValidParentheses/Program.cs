namespace ValidParentheses
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string s = Console.ReadLine();
			Console.WriteLine(Solution.IsValid(s));
		}
	}

	public static class Solution
	{
		public static bool IsValid(string s)
		{
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