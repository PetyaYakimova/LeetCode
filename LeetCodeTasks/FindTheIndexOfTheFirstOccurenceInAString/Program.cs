namespace FindTheIndexOfTheFirstOccurenceInAString
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string haystack = Console.ReadLine();
			string needle = Console.ReadLine();

			Console.WriteLine(Solution.StrStr(haystack, needle));
		}
	}

	public static class Solution
	{
		public static int StrStr(string haystack, string needle)
		{
			return haystack.IndexOf(needle);
		}
	}
}