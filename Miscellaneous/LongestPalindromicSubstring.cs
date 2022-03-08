namespace Miscellaneous;

public class LongestPalindromicSubstring
{
    public string LongestPalindrome(string s)
    {

        int endL=0, startR=0, endR=0, maxL = 0, maxR = 0;
        bool isLooking = false;
        int maxLength = 0;
        int currentLength = 0;

        for(int i=0;i<s.Length;i++)
        {
            if (!isLooking 
                && i + 1 < s.Length && i-1>0 
                && (s[i + 1] == s[i] || s[i + 1] == s[i - 1]))
            {
                if (s[i + 1] == s[i])
                {
                    isLooking = true;
                    endL = i;
                    startR = i + 1;
                    endR = startR;
                    currentLength = 1;
                }
                else if (s[i + 1] == s[i - 1])
                {
                    isLooking = true;
                    endL = i-1;
                    startR = i;
                    endR = startR;
                    currentLength =1;
                }
            }

            if (isLooking && s[startR - endR + endL] == s[i])
            {
                currentLength++;
                endR++;

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxL = endR - currentLength;
                    maxR = endR-1;
                }
            }
            else
            {
                isLooking = false;
                currentLength = 0;
                endR = 0;
            }
        }

        return s.Substring(maxL, maxR-1);
    }
}