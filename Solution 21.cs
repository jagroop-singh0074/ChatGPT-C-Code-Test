using System;
using System.Collections.Generic;

public class Solution {
    public IList<bool> GetResults(int[][] queries) {
        List<int> obstacles = new List<int>();
        List<bool> results = new List<bool>();
        
        foreach (int[] query in queries) {
            if (query[0] == 1) {
                // Type 1 query: Add an obstacle
                int x = query[1];
                int pos = obstacles.BinarySearch(x);
                if (pos < 0) pos = ~pos;
                obstacles.Insert(pos, x);
            }
            else if (query[0] == 2) {
                // Type 2 query: Check if block can be placed
                int x = query[1];
                int sz = query[2];
                bool possible = false;
                // Find the largest gap in [0, x] where the block can fit
                int previous = 0;  // Starting from the origin
                foreach (int obstacle in obstacles) {
                    if (obstacle > x) break;
                    int gap = obstacle - previous;
                    if (gap >= sz) {
                        possible = true;
                        break;
                    }
                    previous = obstacle;
                }
                if (!possible) {
                    // Check the gap from the last obstacle to x
                    if (x - previous >= sz) {
                        possible = true;
                    }
                }
                
                results.Add(possible);
            }
        }
        
        return results;
    }
}
