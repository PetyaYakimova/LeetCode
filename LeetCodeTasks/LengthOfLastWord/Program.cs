namespace LengthOfLastWord
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string s = Console.ReadLine();
			Console.WriteLine(Solution.LengthOfLastWord(s));
		}
	}

	public static class Solution
	{
		public static int LengthOfLastWord(string s)
		{
			string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			return words[words.Length - 1].Length;
		}
	}
}