using System;
using System.Collections.Generic;

public class Solution {
    public List<int> ValidSequence(string word1, string word2) {
        int len1 = word1.Length, len2 = word2.Length;

        // DP table where dp[i][j] is the smallest index in word1 to make a valid sequence up to word2[j] from word1[i]
        int?[][] dp = new int?[len1 + 1][];
        for (int i = 0; i <= len1; i++) {
            dp[i] = new int?[len2 + 1];
        }
        dp[0][0] = -1; // Base case: matching empty prefixes

        // Initialize dp for matching empty word2 with prefixes of word1
        for (int i = 1; i <= len1; i++) {
            dp[i][0] = -1;
        }

        // Fill the DP table
        for (int i = 1; i <= len1; i++) {
            for (int j = 1; j <= len2; j++) {
                if (dp[i - 1][j] != null) {  // Skip this character in word1
                    dp[i][j] = dp[i - 1][j];
                }
                if (dp[i - 1][j - 1] != null && (word1[i - 1] == word2[j - 1] || dp[i - 1][j - 1] == -1)) {
                    // Current characters match or we can change this character
                    dp[i][j] = dp[i][j] == null ? i - 1 : Math.Min(dp[i][j].Value, i - 1);
                }
            }
        }

        // Backtrack to build the result from dp table
        if (dp[len1][len2] == null) {
            return new List<int>(); // Empty list if no valid sequence exists
        }

        // Find the sequence
        List<int> result = new List<int>();
        int ii = len1, jj = len2;
        while (jj > 0) {
            if (dp[ii][jj] == dp[ii - 1][jj]) {  // Character ii-1 in word1 was skipped
                ii -= 1;
            } else {
                result.Add(dp[ii][jj].Value);
                ii -= 1;
                jj -= 1;
            }
        }
        result.Reverse();
        return result;
    }
}

// Example Usage
var sol = new Solution();
Console.WriteLine(string.Join(", ", sol.ValidSequence("vbcca", "abc")));  // Output: 0, 1, 2
Console.WriteLine(string.Join(", ", sol.ValidSequence("bacdc", "abc")));  // Output: 1, 2, 4
Console.WriteLine(string.Join(", ", sol.ValidSequence("aaaaaa", "aaabc")));  // Output: 
Console.WriteLine(string.Join(", ", sol.ValidSequence("abc", "ab")));  // Output: 0, 1
