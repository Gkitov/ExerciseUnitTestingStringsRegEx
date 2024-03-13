using NUnit.Framework;

using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    [TestCase(new string[] { }, "")]
    [TestCase(new string[] { "" }, "")]
    [TestCase(new string[] { " " }, " ")]
    [TestCase(new string[] { "stosho" }, "stosho")]
    [TestCase(new string[] { "Plovdiv", "Sofia","Pernik" }, "PernikSofiaPlovdiv")]
    [TestCase(new string[] { " " }, " ")]
    [TestCase(new string[] { null }, "")]
    [TestCase( null , "")]
    [TestCase(new string[] {"Ivan Shopov","Ilko Kirilov","Some More Words","To be Added" }, "To be AddedSome More WordsIlko KirilovIvan Shopov")]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString(
        string[] input, 
        string expectedResult)
    {

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange

        // Act
        //string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // TODO: finish the test
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        // TODO: finish the test
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // TODO: finish the test
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // TODO: finish the test
    }
}
