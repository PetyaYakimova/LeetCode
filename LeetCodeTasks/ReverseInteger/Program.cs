namespace ReverseInteger
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int inputNumber = int.Parse(Console.ReadLine());
			Console.WriteLine(Solution.Reverse(inputNumber));
		}
	}

	public static class Solution
	{
		public static int Reverse(int x)
		{
			string inputAsString = x.ToString();
			bool isNegative = false;
			if (inputAsString[0] == '-')
			{
				isNegative = true;
				inputAsString = inputAsString.Substring(1);
			}

			char[] charArray = inputAsString.ToCharArray();
			Array.Reverse(charArray);
			string reverseString = new string(charArray);

			if (isNegative)
			{
				reverseString = "-" + reverseString;
			}

			//Check if the reversed string can be represented as int
			int result = 0;
			if (int.TryParse(reverseString, out result))
			{
				result = int.Parse(reverseString);
			}
			
			return result;
		}
	}
}