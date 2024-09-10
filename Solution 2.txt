using System;

public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        // Check if str1 + str2 == str2 + str1
        if (str1 + str2 != str2 + str1) {
            return "";
        }
        
        // Get the GCD of the lengths of str1 and str2
        int gcdLength = Gcd(str1.Length, str2.Length);
        
        // Return the substring from str1 of length gcdLength
        return str1.Substring(0, gcdLength);
    }

    // Helper function to compute the GCD of two numbers
    private int Gcd(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
