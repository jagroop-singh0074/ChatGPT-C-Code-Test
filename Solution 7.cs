public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int length = nums.Length;
        int[] answer = new int[length];
        
        // Initialize answer array with 1's
        for (int i = 0; i < length; i++) {
            answer[i] = 1;
        }
        
        // Calculate prefix products
        int prefix = 1;
        for (int i = 0; i < length; i++) {
            answer[i] = prefix;
            prefix *= nums[i];
        }
        
        // Calculate suffix products and multiply with the prefix products
        int suffix = 1;
        for (int i = length - 1; i >= 0; i--) {
            answer[i] *= suffix;
            suffix *= nums[i];
        }
        
        return answer;
    }
}
