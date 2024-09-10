public class Solution {
    public int MaxArea(int[] height) {
        int left = 0, right = height.Length - 1;
        int maxArea = 0;

        while (left < right) {
            // Calculate the area with the current left and right pointers
            int width = right - left;
            int currentHeight = Math.Min(height[left], height[right]);
            int currentArea = width * currentHeight;
            maxArea = Math.Max(maxArea, currentArea);

            // Move the pointer pointing to the shorter line
            if (height[left] < height[right]) {
                left++;
            } else {
                right--;
            }
        }

        return maxArea;
    }
}
