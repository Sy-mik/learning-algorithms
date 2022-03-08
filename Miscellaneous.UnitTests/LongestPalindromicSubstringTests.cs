using Xunit;

namespace Miscellaneous.UnitTests;

public class LongestPalindromicSubstringTests
{
    private LongestPalindromicSubstring sut = new LongestPalindromicSubstring(); 
    
    
    [Theory]
    [InlineData("dfabbagolcb", "abba")]
    [InlineData("dfabagolcb", "aba")]
   // [InlineData("dfabagolcbbcl", "lcbbcl")]
    public void Test1(string s, string expected)
    {
        var res = sut.LongestPalindrome(s);
        
        Assert.Equal(expected, res);
    }
}