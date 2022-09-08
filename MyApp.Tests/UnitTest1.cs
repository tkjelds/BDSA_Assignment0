using FluentAssertions;
using Xunit;

namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void TestLeap3()
    {
        var LeapYearFunc = new LeapYear();

        var result = LeapYearFunc.IsLeapYear(3);

        result.Should().Be(false);

    }
    [Fact]
    public void TestLeap4()
    {
        var LeapYearFunc = new LeapYear();

        var result = LeapYearFunc.IsLeapYear(4);

        result.Should().Be(true);

    }
    [Fact]
    public void TestLeap100()
    {
        var LeapYearFunc = new LeapYear();

        var result = LeapYearFunc.IsLeapYear(100);

        result.Should().Be(false);

    }
    [Fact]
    public void TestLeap400()
    {
        var LeapYearFunc = new LeapYear();

        var result = LeapYearFunc.IsLeapYear(400);

        result.Should().Be(true);

    }
    [Fact]
    public void TestStringToIntConverter_Fail(){
        var STICon = new StringToIntConverter();

        var result = STICon.Convert("test");

        result.Should().Be(-1);
    }
    [Fact]
    public void TestStringToIntConverter_Succees(){
        var STICon = new StringToIntConverter();

        var result = STICon.Convert("2000");

        result.Should().Be(2000);
    }

    [Fact]
    public void testStringToIntConverter_fail_with_number_smaller_than_1582(){
        var STICon = new StringToIntConverter();

        var result = STICon.Convert("100");

        result.Should().Be(-2);
    }

}