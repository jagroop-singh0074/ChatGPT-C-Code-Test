public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numDict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            int complement = target - num;
            if (numDict.ContainsKey(complement)) {
                return new int[] { numDict[complement], i };
            }
            if (!numDict.ContainsKey(num)) {
                numDict[num] = i;
            }
        }
        return new int[] { };  // Return empty array if no solution is found
    }
}

// Usage within the same file
public static void Main() {
    Solution sol = new Solution();
    int[] result = sol.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
    Console.WriteLine($"[{result[0]}, {result[1]}]");  // Output: [0, 1]
    result = sol.TwoSum(new int[] { 3, 2, 4 }, 6);
    Console.WriteLine($"[{result[0]}, {result[1]}]");  // Output: [1, 2]
    result = sol.TwoSum(new int[] { 3, 3 }, 6);
    Console.WriteLine($"[{result[0]}, {result[1]}]");  // Output: [0, 1]
}
