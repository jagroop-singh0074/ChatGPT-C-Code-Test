public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        // Initialize two variables to track the smallest and second smallest elements
        int first = int.MaxValue;
        int second = int.MaxValue;
        
        foreach (int num in nums) {
            if (num <= first) {
                first = num;  // Update the smallest element
            } else if (num <= second) {
                second = num;  // Update the second smallest element
            } else {
                // If we find a number greater than both first and second, triplet exists
                return true;
            }
        }
        
        return false;
    }
}
