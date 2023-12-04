namespace AdventOfCode._2023.Day01.Solution;

public static class Program
{
    public static void Main(string[] args)
    {
        string[] inputFileContent = getInputFileContent();
        int calibrationValue = getCalibrationValue(inputFileContent);

        Console.WriteLine($"CalibrationValue = {calibrationValue}");
    }

    public static string[] getInputFileContent()
    {
        string inputFilePaht = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "input.txt");
        return File.ReadAllLines(inputFilePaht);
    }

    public static int getCalibrationValue(string[] inputFileContent)
    {
        int calibrationValue = 0;

        foreach(string line in inputFileContent)
        {
            int[] digits = line.GetDigits();

            calibrationValue +=
            Convert.ToInt32(
                digits.FirstOrDefault().ToString()
                + digits.LastOrDefault().ToString()
            );
        }

        return calibrationValue;
    }
}