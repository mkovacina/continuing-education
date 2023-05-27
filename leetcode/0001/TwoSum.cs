using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        return SolveWithOnePass(nums, target);
    }

    public int[] SolveWithOnePass(int[] nums, int target)
    {
        var set = new Dictionary<int, int>(nums.length);

        for(int x = 0; x < nums.Length; x++)
        {
            if (set.TryGetValue(nums[x], out var result))
            {
                if (x == result) continue;

                return new int[] { x, result };
            }
            
            set[target-nums[x]] = x;
        }

        return null;
    }

    public int[] SolveWithDictionary(int[] nums, int target)
    {
        var set = new Dictionary<int, int>();

        for (int x = 0; x < nums.Length; x++)
        {
            set[target-nums[x]] = x;
        }

        for (int x = 0; x < nums.Length; x++)
        {
            if (set.TryGetValue(nums[x], out var result))
            {
                if (x == result) continue;

                return new int[] { x, result };
            }
        }

        return null;
    }
}