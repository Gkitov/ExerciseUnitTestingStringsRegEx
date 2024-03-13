using NUnit.Framework;

using System;
using System.Security.Cryptography.X509Certificates;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = new string[] { };
        string text = "Lorem ipsum etc.";
        string expectedResult = "Lorem ipsum etc.";
        // Act
        string actualResult = TextFilter.Filter(bannedWords, text);
        // Assert
        Assert.That(actualResult, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = new string[] { "name" };
        string text = "Hello, my name is StoSho";
        string expectedResult = "Hello, my **** is StoSho";
        // Act
        string actualResult = TextFilter.Filter(bannedWords, text);
        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = new string[] { };
        string text = "Some crazy text here";
        string expectedResult = "Some crazy text here";
        // Act
        string actualResult = TextFilter.Filter(bannedWords, text);
        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        string[] bannedWords = new string[] { "live", "but", "from Plovdiv" };
        string text = "Hello, I'm StoSho and live in Sofia, but I'm from Plovdiv";
        string expectedResult = "Hello, I'm StoSho and **** in Sofia, *** I'm ************";
        // Act
        string actualResult = TextFilter.Filter(bannedWords, text);
        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
