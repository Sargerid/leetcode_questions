public class Solution {
    public int LengthOfLastWord(string s) {
        string[] words = s.Trim().Split(' ');
        string lastWord = words[words.Length - 1];
        int wordLength = lastWord.Length;
        return wordLength;
    }
}
