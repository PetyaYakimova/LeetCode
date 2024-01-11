using System.Text;

namespace LetterCombinationsOfAPhoneNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string digits = Console.ReadLine();
			Console.WriteLine(string.Join(", ", Solution.LetterCombinations(digits)));
		}
	}

	public static class Solution
	{
		public static IList<string> LetterCombinations(string digits)
		{
			if (digits.Length <= 0)
			{
				return new List<string>();
			}

			Dictionary<char, List<char>> phone = new Dictionary<char, List<char>>();
			phone.Add('2', new List<char>() { 'a', 'b', 'c' });
			phone.Add('3', new List<char>() { 'd', 'e', 'f' });
			phone.Add('4', new List<char>() { 'g', 'h', 'i' });
			phone.Add('5', new List<char>() { 'j', 'k', 'l' });
			phone.Add('6', new List<char>() { 'm', 'n', 'o' });
			phone.Add('7', new List<char>() { 'p', 'q', 'r', 's' });
			phone.Add('8', new List<char>() { 't', 'u', 'v' });
			phone.Add('9', new List<char>() { 'w', 'x', 'y', 'z' });

			List<List<char>> optionsForEveryDigit = new List<List<char>>();
			int totalNumberOfOptions = 1;
			foreach (char digit in digits)
			{
				optionsForEveryDigit.Add(phone[digit]);
				totalNumberOfOptions *= phone[digit].Count();
			}

			string[] options = new string[totalNumberOfOptions];

			for (int digitNumber = 0; digitNumber < digits.Length; digitNumber++)
			{
				int currentOption = 0;
				for (int i = 0; i < totalNumberOfOptions; i++)
				{
					if (currentOption == optionsForEveryDigit[digitNumber].Count)
					{
						currentOption = 0;
					}
					options[i] += optionsForEveryDigit[digitNumber][currentOption];

					currentOption++;
				}

				options = options.OrderBy(x => x).ToArray();
			}

			return options.ToList();
		}
	}
}