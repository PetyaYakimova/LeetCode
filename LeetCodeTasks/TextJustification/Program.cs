using System.Text;

namespace TextJustification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            int maxWidth = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Join(Environment.NewLine, Solution.FullJustify(words, maxWidth)));
        }
    }

    public static class Solution
    {
        public static IList<string> FullJustify(string[] words, int maxWidth)
        {
            int currentWordIndex = 0;

            //Split the words into lines
            List<List<string>> allLines = new List<List<string>>();
            List<string> currentLine = new List<string>();
            int currentLineLength = 0;

            while (currentWordIndex < words.Length)
            {
                string currentWord = words[currentWordIndex];
                int needSpace = 0;
                if (currentLine.Any())
                {
                    needSpace = 1;
                }
                if (currentLineLength + currentWord.Length + needSpace <= maxWidth)
                {
                    currentLine.Add(currentWord);
                    currentLineLength += currentWord.Length + needSpace;
                }
                else
                {
                    allLines.Add(currentLine);
                    currentLine = new List<string>();
                    currentLine.Add(currentWord);
                    currentLineLength = currentWord.Length;
                }

                currentWordIndex++;
            }

            allLines.Add(currentLine);


            //Make the words for each line into a string
            IList<string> result = new List<string>();
            for (int j = 0; j < allLines.Count(); j++)
            {
                List<string> line = allLines[j];
                if (line.Count() == 1)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(line[0]);
                    sb.Append(new string(' ', maxWidth - line[0].Length));

                    result.Add(sb.ToString());
                }
                else if (j == allLines.Count() - 1)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(string.Join(' ', line));
                    sb.Append(new string(' ', maxWidth - sb.ToString().Length));

                    result.Add(sb.ToString());
                }
                else
                {
                    int wordCharacters = line.Sum(w => w.Length);
                    int spaceCharacters = maxWidth - wordCharacters;
                    int numberOfSpaces = line.Count() - 1;

                    int higherNumberOfSpaces = (int)Math.Ceiling((double)spaceCharacters / numberOfSpaces);
                    int lowerNumberOfSpace = (int)Math.Floor((double)spaceCharacters / numberOfSpaces);
                    int countOfHigherNumberofSpaces = 0;
                    while (spaceCharacters % numberOfSpaces != 0)
                    {
                        countOfHigherNumberofSpaces++;
                        spaceCharacters -= higherNumberOfSpaces;
                        numberOfSpaces--;
                    }

                    StringBuilder sb = new StringBuilder();
                    sb.Append(line[0]);
                    for (int i = 1; i <= countOfHigherNumberofSpaces; i++)
                    {
                        sb.Append(new string(' ', higherNumberOfSpaces));
                        sb.Append(line[i]);
                    }
                    for (int i = countOfHigherNumberofSpaces + 1; i < line.Count(); i++)
                    {
                        sb.Append(new string(' ', lowerNumberOfSpace));
                        sb.Append(line[i]);
                    }

                    result.Add(sb.ToString());
                }
            }

            return result;
        }
    }
}