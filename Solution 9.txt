public class Solution {
    public int Compress(char[] chars) {
        int write = 0; // Pointer to write the compressed result
        int read = 0;  // Pointer to read the array

        while (read < chars.Length) {
            char currentChar = chars[read];
            int count = 0;

            // Count consecutive repeating characters
            while (read < chars.Length && chars[read] == currentChar) {
                read++;
                count++;
            }

            // Write the character
            chars[write] = currentChar;
            write++;

            // Write the count if greater than 1
            if (count > 1) {
                foreach (char digit in count.ToString()) {
                    chars[write] = digit;
                    write++;
                }
            }
        }

        return write;
    }
}
