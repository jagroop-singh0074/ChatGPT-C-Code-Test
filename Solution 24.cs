public class Solution {
    public int MaximumValueSum(int[][] board) {
        int m = board.Length;
        int n = board[0].Length;
        int maxSum = int.MinValue;

        // Try placing rooks in all possible column combinations
        for (int col1 = 0; col1 < n; col1++) {
            for (int col2 = col1 + 1; col2 < n; col2++) {
                for (int col3 = col2 + 1; col3 < n; col3++) {
                    // For each combination of columns, find the best arrangement of rows
                    for (int row = 0; row < m; row++) {
                        int sumVal = board[row][col1] +
                                     board[(row + 1) % m][col2] +
                                     board[(row + 2) % m][col3];
                        maxSum = Math.Max(maxSum, sumVal);
                    }
                }
            }
        }

        return maxSum;
    }
}
