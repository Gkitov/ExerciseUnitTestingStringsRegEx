using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    // TODO: finish the test
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";

        // Act

        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert

        string expectedResult = "The quick brown jumps over the lazy dog";
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "Hello";
        string input = "Hello, my name is StoSho!";
        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        string expectedResult = ", my name is StoSho!";
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "Golf 3";
        string input = "The best car in the world is Golf 3!";
        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        string expectedResult = "The best car in the world is !";
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "Golf";
        string input = "The first Golf was made in 1976, and latest version of Golf is from 2024.The best car in the world is not Golf.";
        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        string expectedResult = "The first was made in 1976, and latest version of is from 2024.The best car in the world is not .";
        Assert.AreEqual(expectedResult, result);
    }
}
