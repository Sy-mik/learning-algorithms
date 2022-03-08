namespace Miscellaneous;

public class SlidingWindow
{
    public int MinimumWindowSubstring(string res, string target)
    {
        int left = 0, right = 0, match = 0;
        Dictionary<char, int> window = new Dictionary<char, int>();
        Dictionary<char, int> needed = new Dictionary<char, int>();
        foreach (var c in target)
        {
            AddOrIncrement(needed, c);
        }

        var start = 0;
        var minimum = int.MaxValue;
        while (right < res.Length)
        {
            var c1 = res[right];
            if (needed.ContainsKey(c1))
            {
                AddOrIncrement(window, c1);
                if (window.GetValueOrDefault(c1, -1) == needed[c1])
                {
                    match++;
                }
            }

            right++;

            while (match==needed.Count)
            {
                if (right - left < minimum)
                {
                    start = left;
                    minimum = right - left;
                }
                
                
                char c2 = res[left];
                if (needed.ContainsKey(c2))
                {
                    AddOrDecrement(window, c2);
                    if (window[c2] < needed[c2])
                        match--;
                }
                left++;
            }
        }
        
        return minimum;
    }
    //
    //
    // public int lengthOfLongestSubstring(string s) {
    //     int left = 0, right = 0;
    //     Dictionary<char, int> window = new Dictionary<char, int>();
    //     int res = 0; // Record maximum length
    //
    //     while (right < s.Length) {
    //         char c1 = s[right];
    //         AddOrIncrement(window, c1);
    //         right++;
    //         // If a duplicate character appears in the window
    //         // Move the left pointer
    //         while (window[c1] > 1) {
    //             char c2 = s[left];
    //             AddOrDecrement(window, c1);
    //             left++;
    //         }
    //         res = Math.Max(res, right - left);
    //     }
    //     return res;
    // }
    
    private void AddOrDecrement(Dictionary<char, int> dict, char c)
    {
            dict[c] -= 1;
    }
    private void AddOrIncrement(Dictionary<char, int> dict, char c)
    {
        if (dict.ContainsKey(c))
            dict[c] += 1;
        else dict[c] = 1;
    }
}