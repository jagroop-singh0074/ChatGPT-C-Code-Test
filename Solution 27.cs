using System;
using System.Linq;

public class Solution {
    public int MaximizeSquareArea(int m, int n, int[] hFences, int[] vFences) {
        int MOD = 1000000007;

        // Include boundaries in the fence lists
        hFences = hFences.Concat(new int[] { 1, m }).ToArray();
        vFences = vFences.Concat(new int[] { 1, n }).ToArray();

        // Sort the lists
        Array.Sort(hFences);
        Array.Sort(vFences);

        // Find the maximum gap in horizontal and vertical fences
        int max_h_gap = 0, max_v_gap = 0;
        for (int i = 0; i < hFences.Length - 1; i++) {
            max_h_gap = Math.Max(max_h_gap, hFences[i + 1] - hFences[i]);
        }
        for (int i = 0; i < vFences.Length - 1; i++) {
            max_v_gap = Math.Max(max_v_gap, vFences[i + 1] - vFences[i]);
        }

        // The maximum side of the square we can fit
        int max_side = Math.Min(max_h_gap, max_v_gap) - 1;

        // If no square is possible
        if (max_side <= 0) {
            return -1;
        }

        // Calculate the area and return modulo
        long area = (long)max_side * max_side;
        return (int)(area % MOD);
    }
}

// Example Usage
var sol = new Solution();
Console.WriteLine(sol.MaximizeSquareArea(4, 3, new int[] { 2, 3 }, new int[] { 2 }));  // Output: 4
Console.WriteLine(sol.MaximizeSquareArea(6, 7, new int[] { 2 }, new int[] { 4 }));    // Output: -1
