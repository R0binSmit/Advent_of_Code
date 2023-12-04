using System.Text.RegularExpressions;

namespace AdventOfCode._2023.Day01.Solution;

public static class StringExtensions
{
    private static readonly string digitRegex = @"(?=(\d|zero|one|two|three|four|five|six|seven|eight|nine))";
    private static readonly List<KeyValuePair<string, int>> digitsMappingList = new List<KeyValuePair<string, int>>() 
    { 
        new KeyValuePair<string, int>("zero", 0),
        new KeyValuePair<string, int>("one", 1),
        new KeyValuePair<string, int>("two", 2),
        new KeyValuePair<string, int>("three", 3),
        new KeyValuePair<string, int>("four", 4),
        new KeyValuePair<string, int>("five", 5),
        new KeyValuePair<string, int>("six", 6),
        new KeyValuePair<string, int>("seven", 7),
        new KeyValuePair<string, int>("eight", 8),
        new KeyValuePair<string, int>("nine", 9),

        new KeyValuePair<string, int>("0", 0),
        new KeyValuePair<string, int>("1", 1),
        new KeyValuePair<string, int>("2", 2),
        new KeyValuePair<string, int>("3", 3),
        new KeyValuePair<string, int>("4", 4),
        new KeyValuePair<string, int>("5", 5),
        new KeyValuePair<string, int>("6", 6),
        new KeyValuePair<string, int>("7", 7),
        new KeyValuePair<string, int>("8", 8),
        new KeyValuePair<string, int>("9", 9),
    };

    public static int[] GetDigits(this string str)
    {
        str = str.Trim().ToLower();
        List<int> digits = new List<int>();
        Regex rx = new Regex(digitRegex);
        MatchCollection matches = rx.Matches(str);

        foreach (Match match in matches)
        {
            KeyValuePair<string, int> digitKeyValuePair = digitsMappingList.Where(x => x.Key == match.Groups[1].Value).FirstOrDefault();
            digits.Add(digitKeyValuePair.Value);
        }

        return digits.ToArray();
    }
}
