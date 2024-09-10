public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var merged = new System.Text.StringBuilder();
        int i = 0, j = 0;
        
        // Merge characters in alternating order
        while (i < word1.Length && j < word2.Length) {
            merged.Append(word1[i]);
            merged.Append(word2[j]);
            i++;
            j++;
        }
        
        // Append remaining characters from the longer word
        if (i < word1.Length) {
            merged.Append(word1.Substring(i));
        }
        if (j < word2.Length) {
            merged.Append(word2.Substring(j));
        }
        
        return merged.ToString();
    }
}
