public class Solution {
    public int MaxValue(int[] nums, int k) {
        int n = nums.Length;
        int[,] dp = new int[n + 1, k + 1];
        
        for (int i = 1; i <= n; i++) {
            for (int j = 1; j <= Math.Min(i / 2, k); j++) {
                int orValLeft = 0;
                for (int l = i - 1; l >= i - 2 * j; l--) {
                    orValLeft |= nums[l];
                    int orValRight = 0;
                    for (int m = l - 1; m >= i - 2 * j; m--) {
                        orValRight |= nums[m];
                        if (m + j >= i) continue;
                        dp[i, j] = Math.Max(dp[i, j], dp[m, j - 1] ^ (orValLeft | orValRight));
                    }
                }
            }
        }
        
        return dp[n, k];
    }
}
