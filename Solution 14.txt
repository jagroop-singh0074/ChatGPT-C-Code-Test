public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int left = 0;  // Left pointer of the sliding window
        int maxOnes = 0;
        int zeroCount = 0;  // To count the number of 0s in the current window

        // Iterate with the right pointer
        for (int right = 0; right < nums.Length; right++) {
            // If we encounter a 0, increase the zeroCount
            if (nums[right] == 0) {
                zeroCount++;
            }

            // If zeroCount exceeds k, move the left pointer
            while (zeroCount > k) {
                if (nums[left] == 0) {
                    zeroCount--;
                }
                left++;
            }

            // Update the maximum length of 1's (with up to k flips)
            maxOnes = Math.Max(maxOnes, right - left + 1);
        }

        return maxOnes;
    }
}
