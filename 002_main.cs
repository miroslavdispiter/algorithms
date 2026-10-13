// 002 - Valid Anagram
// https://neetcode.io/problems/is-anagram

var s = new Solution();
Console.WriteLine(s.IsAnagram("racecar", "carrace")); // True
Console.WriteLine(s.IsAnagram("jar", "jam")); // False
Console.WriteLine(s.IsAnagram("cart", "ratc")); // True
Console.WriteLine(s.IsAnagram("aab", "abb")); // False

class Solution
{
    public bool IsAnagram(string s, string t){
        
        if(s.Length != t.Length)
        {
            return false;
        }

        int[] charCounts = new int[26];

        for(int i=0; i < s.Length; i++)
        {
            charCounts[s[i] - 'a']++;
            charCounts[t[i] - 'a']--;
        }

        foreach (int count in charCounts)
        {
            if(count != 0)
            {
                return false;
            }
        }

        return true;
    }
}