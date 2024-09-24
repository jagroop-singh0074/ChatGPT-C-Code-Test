using System;
using System.Collections.Generic;

public class Solution {
    public List<int> GetFinalState(List<int> nums, int k, int multiplier) {
        const int MOD = 1000000007;
        
        // Finding minimum value and its index
        int minIndex = 0;
        int minValue = nums[0];
        for (int i = 1; i < nums.Count; i++) {
            if (nums[i] < minValue) {
                minValue = nums[i];
                minIndex = i;
            }
        }

        // Perform the operations on the minimum value
        for (int i = 0; i < k; i++) {
            nums[minIndex] = (int)((long)nums[minIndex] * multiplier % MOD);
        }

        // Apply modulo to all elements as final step
        for (int i = 0; i < nums.Count; i++) {
            nums[i] = nums[i] % MOD;
        }

        return nums;
    }
    
    public static void Main(string[] args) {
        Solution sol = new Solution();
        List<int> nums = new List<int>{2, 1, 3, 5, 6};
        int k = 5;
        int multiplier = 2;
        List<int> result = sol.GetFinalState(nums, k, multiplier);
        Console.WriteLine(string.Join(", ", result));
    }
}
