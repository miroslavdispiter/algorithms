// 001 - Contains Duplicate
// https://neetcode.io/problems/duplicate-integer

var s = new Solution();
Console.WriteLine(s.ContainsDuplicate([1,2,7,3,7])); // True
Console.WriteLine(s.ContainsDuplicate([1,2,3,4,5])); // False

class Solution {
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> seenNumbers = new();

        foreach(int num in nums)
        {
            if(seenNumbers.Contains(num))
            {
                return true;
            }
            seenNumbers.Add(num);
        }
        return false;
    }
}