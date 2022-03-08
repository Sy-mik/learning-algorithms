using Xunit;

namespace Miscellaneous.UnitTests;

public class UnitTest1
{
    private SlidingWindow sut = new SlidingWindow(); 
    [Fact]
    public void Test1()
    {
        var res = sut.MinimumWindowSubstring("adabc", "ac");
        Assert.Equal(3, res);
    }
}