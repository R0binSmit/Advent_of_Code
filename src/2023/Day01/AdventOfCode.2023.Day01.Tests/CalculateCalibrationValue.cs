using NUnit.Framework;

namespace AdventOfCode._2023.Day01.Tests;

public class CalculateCalibrationValue
{
    [Test]
    public void CalculateCalibrationValue_BeginAndEndAreDigits_Return24()
    {
        var inputData = new[] { "2DE4" };

        var calibrationValue = Solution.Program.GetCalibrationValue(inputData);
        Assert.That(calibrationValue, Is.EqualTo(24));
    }

    [Test]
    public void CalculateCalibrationValue_OnlyOneNumber_Return11()
    {
        string[] inputData =
        {
            "1"
        };

        var calibrationValue = Solution.Program.GetCalibrationValue(inputData);
        Assert.That(calibrationValue, Is.EqualTo(11));
    }

    [Test]
    public void CalculateCalibrationValue_NumbersInString_Return23()
    {
        var inputData = new[] { "BLA2DUDA3KI" };

        var calibrationValue = Solution.Program.GetCalibrationValue(inputData);
        Assert.That(calibrationValue, Is.EqualTo(23));
    }
}