public class Solution {
    public string ReverseWords(string s) {
        // Split the string by spaces, remove empty entries, and reverse the array of words
        string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}
