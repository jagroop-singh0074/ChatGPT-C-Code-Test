using System;

public class Solution {
    public int StrongPasswordChecker(string password) {
        int n = password.Length;
        bool hasLower = false, hasUpper = false, hasDigit = false;

        foreach (char ch in password) {
            if (char.IsLower(ch)) hasLower = true;
            if (char.IsUpper(ch)) hasUpper = true;
            if (char.IsDigit(ch)) hasDigit = true;
        }

        int missingTypes = 3 - (Convert.ToInt32(hasLower) + Convert.ToInt32(hasUpper) + Convert.ToInt32(hasDigit));
        
        // Count sequences of three or more repeating characters
        int repeats = 0;
        int i = 2;
        while (i < n) {
            if (password[i] == password[i-1] && password[i-1] == password[i-2]) {
                int length = 2;
                while (i < n && password[i] == password[i-1]) {
                    length++;
                    i++;
                }
                repeats += length / 3;
            } else {
                i++;
            }
        }

        if (n < 6) {
            return Math.Max(missingTypes, 6 - n);
        } else if (n <= 20) {
            return Math.Max(missingTypes, repeats);
        } else {
            int deleteNeeded = n - 20;
            int usingDeletes = Math.Min(deleteNeeded, repeats * 3);
            
            int deleteRemaining = deleteNeeded - usingDeletes;
            repeats -= usingDeletes / 3;
            
            // Further reduce repeats if we still have deletes left
            if (deleteRemaining > 0) {
                if (repeats > 0) {
                    if (deleteRemaining >= repeats) {
                        deleteRemaining -= repeats;
                        repeats = 0;
                    } else {
                        repeats -= deleteRemaining;
                        deleteRemaining = 0;
                    }
                }
            }

            return deleteNeeded + Math.Max(missingTypes, repeats);
        }
    }
}

public static class Program {
    public static void Main() {
        Solution sol = new Solution();
        Console.WriteLine(sol.StrongPasswordChecker("a"));       // Output: 5
        Console.WriteLine(sol.StrongPasswordChecker("aA1"));     // Output: 3
        Console.WriteLine(sol.StrongPasswordChecker("1337C0d3")); // Output: 0
    }
}
