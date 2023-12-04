using NUnit.Framework;

namespace AdventOfCode._2023.Day01.Tests;

public class Tests
{
    [Test]
    public void CalculateCalibrationValue_BeginAndEndAreDigits_Return24()
    {
        string[] inputData =
        {
            "2DE4",
        };

        int calibrationValue = Solution.Program.getCalibrationValue(inputData);
        Assert.IsTrue(calibrationValue == 24);
    }

    [Test]
    public void CalculateCalibrationValue_OnlyOneNumber_Return11()
    {
        string[] inputData =
        {
            "1"
        };

        int calibrationValue = Solution.Program.getCalibrationValue(inputData);
        Assert.IsTrue(calibrationValue == 11);
    }

    [Test]
    public void CalculateCalibrationValue_NumbersInString_Return23()
    {
        string[] inputData =
        {
            "BLA2DUDA3KI"
        };

        int calibrationValue = Solution.Program.getCalibrationValue(inputData);
        Assert.IsTrue(calibrationValue == 23);
    }
}