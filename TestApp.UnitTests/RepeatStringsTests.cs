using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class RepeatStringsTests
{
    [Test]
    public void Test_Repeat_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Repeat_SingleInputString_ReturnsRepeatedString()
    {
        //Arrange
        string[] input = new string[] { "sto" };

        //Act
        string result = RepeatStrings.Repeat(input);

        //Assert
        string expectedResult = "stostosto";
        Assert.That (result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Repeat_MultipleInputStrings_ReturnsConcatenatedRepeatedStrings()
    {
        string[] input = new string[] { "3421", "AbA" };

        string result = RepeatStrings.Repeat(input);

        string expectedResult = "3421342134213421AbAAbAAbA";
        Assert.That(result, Is.EqualTo (expectedResult));
    }
}
