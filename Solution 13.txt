public class Solution {
    public int MaxVowels(string s, int k) {
        HashSet<char> vowels = new HashSet<char>{ 'a', 'e', 'i', 'o', 'u' };  // Set of vowels
        int maxVowels = 0;
        int currentVowels = 0;
        
        // Count vowels in the first window of size k
        for (int i = 0; i < k; i++) {
            if (vowels.Contains(s[i])) {
                currentVowels++;
            }
        }
        
        maxVowels = currentVowels;
        
        // Use a sliding window approach
        for (int i = k; i < s.Length; i++) {
            if (vowels.Contains(s[i])) {  // Add new character in the window
                currentVowels++;
            }
            if (vowels.Contains(s[i - k])) {  // Remove the character that goes out of the window
                currentVowels--;
            }
            maxVowels = Math.Max(maxVowels, currentVowels);
        }
        
        return maxVowels;
    }
}
