using Xunit;

namespace MyFirstUnitTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(4, Add(2, 2));
    }

    [Fact]
    public void FailingTest()
    {
        Assert.Equal(5, Add(2, 2));
    }

    int Add(int x, int y)
    {
        return x + y;
    }

    [Theory]
    [InlineData(3, true)]
    [InlineData(5, true)]
    [InlineData(6, false)]
    public void MyFirstTheory(int value, bool expectedResult)
    {
        Assert.Equal(expectedResult, IsOdd(value));
    }

    bool IsOdd(int value)
    {
        return value % 2 == 1;
    }
}
