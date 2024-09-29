public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romanToInteger = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        
        int total = 0;
        
        for (int i = 0; i < s.Length; i++) {
            int value = romanToInteger[s[i]];
            
            // Check if the current value is less than the next to determine if we need to subtract
            if (i < s.Length - 1 && value < romanToInteger[s[i + 1]]) {
                total -= value;
            } else {
                total += value;
            }
        }
        
        return total;
    }
}

// Usage
var sol = new Solution();
Console.WriteLine(sol.RomanToInt("III"));    // Output: 3
Console.WriteLine(sol.RomanToInt("LVIII"));  // Output: 58
Console.WriteLine(sol.RomanToInt("MCMXCIV"));// Output: 1994
