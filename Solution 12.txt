public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        // Calculate the sum of the first 'k' elements
        int currentSum = 0;
        for (int i = 0; i < k; i++) {
            currentSum += nums[i];
        }
        
        int maxSum = currentSum;

        // Iterate over the remaining elements and update the window
        for (int i = k; i < nums.Length; i++) {
            currentSum += nums[i] - nums[i - k];  // Sliding window update
            maxSum = Math.Max(maxSum, currentSum); // Track the maximum sum
        }

        // Return the maximum average
        return (double)maxSum / k;
    }
}
