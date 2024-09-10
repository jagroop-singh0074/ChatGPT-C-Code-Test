public class Solution {
    public string ReverseVowels(string s) {
        HashSet<char> vowels = new HashSet<char>{'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        char[] chars = s.ToCharArray();
        int left = 0, right = s.Length - 1;

        while (left < right) {
            if (!vowels.Contains(chars[left])) {
                left++;
            } else if (!vowels.Contains(chars[right])) {
                right--;
            } else {
                // Swap vowels
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                left++;
                right--;
            }
        }

        return new string(chars);  // Convert char array back to string
    }
}
