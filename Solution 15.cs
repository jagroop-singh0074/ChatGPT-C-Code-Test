public class Solution {
    public int LongestSubarray(int[] nums) {
        int left = 0;
        int zeroCount = 0;
        int maxLength = 0;

        // Sliding window approach
        for (int right = 0; right < nums.Length; right++) {
            if (nums[right] == 0) {
                zeroCount++;
            }
            
            // Shrink window if there are more than 1 zero
            while (zeroCount > 1) {
                if (nums[left] == 0) {
                    zeroCount--;
                }
                left++;
            }
            
            // Calculate the maximum length of subarray with at most 1 zero
            maxLength = Math.Max(maxLength, right - left);
        }
        
        return maxLength;
    }
}
