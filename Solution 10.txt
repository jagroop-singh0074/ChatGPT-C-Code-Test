public class Solution {
    public void MoveZeroes(int[] nums) {
        int nonZeroIndex = 0;

        // Move all non-zero elements to the front of the array
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                nums[nonZeroIndex] = nums[i];
                nonZeroIndex++;
            }
        }

        // Fill the rest of the array with 0s
        for (int i = nonZeroIndex; i < nums.Length; i++) {
            nums[i] = 0;
        }
    }
}
