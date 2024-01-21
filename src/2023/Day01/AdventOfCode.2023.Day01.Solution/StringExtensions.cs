using System.Text.RegularExpressions;

namespace AdventOfCode._2023.Day01.Solution;

public static partial class StringExtensions
{
    private static readonly List<KeyValuePair<string, int>> DigitsMappingList = new List<KeyValuePair<string, int>> 
    { 
        new ("zero", 0),
        new ("one", 1),
        new ("two", 2),
        new ("three", 3),
        new ("four", 4),
        new ("five", 5),
        new ("six", 6),
        new ("seven", 7),
        new ("eight", 8),
        new ("nine", 9),

        new ("0", 0),
        new ("1", 1),
        new ("2", 2),
        new ("3", 3),
        new ("4", 4),
        new ("5", 5),
        new ("6", 6),
        new ("7", 7),
        new ("8", 8),
        new ("9", 9)
    };

    public static int[] GetDigits(this string str)
    {
        str = str.Trim().ToLower();
        var digits = new List<int>();
        var rx = DigitRegex();
        var matches = rx.Matches(str);

        foreach (Match match in matches)
        {
            var digitKeyValuePair = 
                DigitsMappingList.FirstOrDefault(x => x.Key == match.Groups[1].Value);
            digits.Add(digitKeyValuePair.Value);
        }

        return digits.ToArray();
    }

    [GeneratedRegex("(?=(\\d|zero|one|two|three|four|five|six|seven|eight|nine))")]
    private static partial Regex DigitRegex();
}
