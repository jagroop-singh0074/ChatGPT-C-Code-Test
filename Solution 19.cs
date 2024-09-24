using System;
using System.Collections.Generic;

public class Solution {
    public int MaxValue(int[] nums, int k) {
        int n = nums.Length;
        int max_value = 0;

        // Get all combinations of 2k elements using a helper function
        foreach (var comb in GetCombinations(nums, 2 * k)) {
            int or1 = 0, or2 = 0;
            // Compute OR for the first k elements
            for (int i = 0; i < k; i++)
                or1 |= comb[i];
            // Compute OR for the second k elements
            for (int i = k; i < 2 * k; i++)
                or2 |= comb[i];
            // Compute the XOR of the two OR values
            max_value = Math.Max(max_value, or1 ^ or2);
        }
        return max_value;
    }

    // Helper function to generate combinations of size k from array
    private IEnumerable<int[]> GetCombinations(int[] nums, int k) {
        int[] result = new int[k];
        Stack<int> stack = new Stack<int>();
        stack.Push(0);

        while (stack.Count > 0) {
            int index = stack.Count - 1;
            int value = stack.Pop();

            if (index == k) {
                yield return result;
            } else {
                for (int i = value; i < nums.Length; i++) {
                    result[index] = nums[i];
                    stack.Push(i + 1);
                }
            }
        }
    }
}

// Example usage
var sol = new Solution();
int[] nums1 = {2, 6, 7};
int k1 = 1;
Console.WriteLine(sol.MaxValue(nums1, k1));  // Output: 5

int[] nums2 = {4, 2, 5, 6, 7};
int k2 = 2;
Console.WriteLine(sol.MaxValue(nums2, k2));  // Output: 2
