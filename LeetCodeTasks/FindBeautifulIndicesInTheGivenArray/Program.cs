namespace FindBeautifulIndicesInTheGivenArray
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string s = Console.ReadLine();
			string a = Console.ReadLine();
			string b = Console.ReadLine();
			int k = int.Parse(Console.ReadLine());

			Console.WriteLine(string.Join(", ", Solution.BeautifulIndices(s, a, b, k)));
		}
	}

	public static class Solution
	{
		public static IList<int> BeautifulIndices(string s, string a, string b, int k)
		{
			IList<int> results = new List<int>();
			for (int i = 0; i <= s.Length - a.Length; i++)
			{
				if (s.Substring(i, (a.Length)) == a)
				{
					for (int j = 0; j <= s.Length - b.Length; j++)
					{
						if (Math.Abs(j - i) <= k && s.Substring(j, b.Length) == b)
						{
							results.Add(i);
							break;
						}
					}
				}
			}

			return results;
		}
	}
}