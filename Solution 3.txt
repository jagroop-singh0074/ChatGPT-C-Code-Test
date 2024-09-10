using System;
using System.Collections.Generic;

public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        // Find the maximum number of candies any kid has
        int maxCandies = 0;
        foreach (int candy in candies) {
            maxCandies = Math.Max(maxCandies, candy);
        }
        
        // Create the result list
        IList<bool> result = new List<bool>();
        
        // Check for each kid if they can have the greatest number of candies
        foreach (int candy in candies) {
            result.Add(candy + extraCandies >= maxCandies);
        }
        
        return result;
    }
}
