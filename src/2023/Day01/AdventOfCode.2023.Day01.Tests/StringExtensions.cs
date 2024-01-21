using AdventOfCode._2023.Day01.Solution;
using NUnit.Framework;

namespace AdventOfCode._2023.Day01.Tests;

public class StringExtensions
{
    [Test]
    public void StringGetDigits_NormalDigitsAsStringInput_ArrayOfDigits()
    {
        const string input = "01dfei2Ei36ki9845dsfas79";
        int[] expectation = { 0, 1, 2, 3, 6, 9, 8, 4, 5, 7, 9 };
        var digits = input.GetDigits();

        Assert.That(expectation, Is.EqualTo(digits));
    }

    [Test]
    public void StringGetDigits_FullWrittenNumberAsStringInput_ArrayOfDigits()
    {
        const string input = "zeroonejiocTwodidkoeythreefourhudsae34fiveSixdgysevenEightdfsnine";
        var expectation = new[] { 0, 1, 2, 3, 4, 3, 4, 5, 6, 7, 8, 9 };
        var digits = input.GetDigits();

        Assert.That(expectation, Is.EqualTo(digits));
    }

    [Test]
    public void StringGetDigits_CombinedFullWrittenNumber_ArrayOfDigits()
    {
        const string input = "6udihfvsrhoneight";
        var expectation = new[] { 6, 1, 8 };
        var digits = input.GetDigits();

        Assert.That(expectation, Is.EqualTo(digits));
    }
}