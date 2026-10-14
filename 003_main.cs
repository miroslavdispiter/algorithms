// 003 - Two Sum
// https://neetcode.io/problems/two-sum

var s = new Solution();
Console.WriteLine(string.Join(", ", s.TwoSum([1, 7, 3, 2], 9)));

class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dictionary = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (dictionary.ContainsKey(complement))
            {
                return [dictionary[complement], i];
            }

            dictionary.Add(nums[i], i);
        }

        return new int[] {};
    }
}