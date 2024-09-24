using System;
using System.Collections.Generic;

public class Solution {
    public int MaxScore(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        var allValues = new HashSet<int>();
        foreach (var row in grid) {
            foreach (int val in row) {
                allValues.Add(val);
            }
        }
        
        var valueToBit = new Dictionary<int, int>();
        int bitIndex = 0;
        foreach (int val in allValues) {
            valueToBit[val] = bitIndex++;
        }
        int fullMask = (1 << allValues.Count) - 1;
        var memo = new Dictionary<(int, int), int>();

        int Dfs(int row, int bitmask) {
            if (row == rows) return 0;
            if (memo.ContainsKey((row, bitmask))) return memo[(row, bitmask)];

            int maxScore = 0;
            foreach (int value in grid[row]) {
                int bit = valueToBit[value];
                if ((bitmask & (1 << bit)) == 0) {
                    maxScore = Math.Max(maxScore, value + Dfs(row + 1, bitmask | (1 << bit)));
                }
            }
            
            memo[(row, bitmask)] = maxScore;
            return maxScore;
        }

        return Dfs(0, 0);
    }
}
