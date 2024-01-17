namespace GroupAnagrams
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] strs = Console.ReadLine().Split(", ").ToArray();
			IList<IList<string>> result = Solution.GroupAnagrams(strs);
			foreach (IList<string> group in result)
			{
				Console.WriteLine(String.Join(", ", group));
			}
		}
	}

	public static class Solution
	{
		public static IList<IList<string>> GroupAnagrams(string[] strs)
		{
			IList<IList<string>> result = new List<IList<string>>();

			foreach (string str in strs) 
			{
				bool isInAnyList = false;
				for (int i = 0; i < result.Count; i++)
				{
					List<char> firstStringInResult = result[i][0].ToList();
					if (firstStringInResult.Count() == str.Length)
					{
						bool isInThisList = true;
						for (int j = 0; j < str.Length; j++)
						{
							if (firstStringInResult.Contains(str[j]))
							{
								firstStringInResult.Remove(str[j]);
							}
							else
							{
								isInThisList = false;
								break;
							}
						}

						if (isInThisList)
						{
							isInAnyList = true;
							result[i].Add(str);
							break;
						}
					}
				}

				if (!isInAnyList)
				{
					IList<string> newList = new List<string>();
					newList.Add(str);
					result.Add(newList);
				}
			}

			return result;
		}
	}
}