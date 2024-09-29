using System;
using System.Collections.Generic;

public class Solution {
    public int MaximumValueSum(int[][] board) {
        int m = board.Length, n = board[0].Length;
        int maxSum = int.MinValue;

        void Backtrack(int row, HashSet<int> colsUsed, int currentSum, int rooksPlaced) {
            if (rooksPlaced == 3) {
                maxSum = Math.Max(maxSum, currentSum);
                return;
            }

            for (int i = row; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (!colsUsed.Contains(j)) {
                        colsUsed.Add(j);
                        Backtrack(i + 1, colsUsed, currentSum + board[i][j], rooksPlaced + 1);
                        colsUsed.Remove(j);
                    }
                }
            }
        }

        Backtrack(0, new HashSet<int>(), 0, 0);
        return maxSum;
    }
}

// Example usage
var sol = new Solution();
Console.WriteLine(sol.MaximumValueSum(new int[][] { new int[] { -3, 1, 1, 1 }, new int[] { -3, 1, -3, 1 }, new int[] { -3, 2, 1, 1 } }));  // Output: 4
Console.WriteLine(sol.MaximumValueSum(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } }));               // Output: 15
Console.WriteLine(sol.MaximumValueSum(new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 } }));               // Output: 3
