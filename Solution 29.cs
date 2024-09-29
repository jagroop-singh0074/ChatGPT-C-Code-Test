public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0 || (x % 10 == 0 && x != 0)) {
            return false;
        }
        
        int reversedHalf = 0;
        while (x > reversedHalf) {
            reversedHalf = reversedHalf * 10 + x % 10;
            x /= 10;
        }
        
        // Check if the front half of the number matches the reversed second half
        return x == reversedHalf || x == reversedHalf / 10;
    }
}

// Usage within a C# environment
public static void Main() {
    Solution sol = new Solution();
    Console.WriteLine(sol.IsPalindrome(121));  // Output: True
    Console.WriteLine(sol.IsPalindrome(-121)); // Output: False
    Console.WriteLine(sol.IsPalindrome(10));   // Output: False
}
