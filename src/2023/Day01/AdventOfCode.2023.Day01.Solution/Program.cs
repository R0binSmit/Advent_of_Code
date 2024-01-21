namespace AdventOfCode._2023.Day01.Solution;

public static class Program
{
    public static void Main()
    {
        var inputFileContent = GetInputFileContent();
        var calibrationValue = GetCalibrationValue(inputFileContent);

        Console.WriteLine($"CalibrationValue = {calibrationValue}");
    }

    private static IEnumerable<string> GetInputFileContent()
    {
        var inputFilePaht = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "input.txt");
        return File.ReadAllLines(inputFilePaht);
    }

    public static int GetCalibrationValue(IEnumerable<string> inputFileContent)
    {
        return inputFileContent
            .Select(line => line.GetDigits())
            .Select(digits => Convert.ToInt32(digits.FirstOrDefault() + digits.LastOrDefault().ToString()))
            .Sum();
    }
}