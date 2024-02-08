public class Solution {
    public int Reverse(int x) {
        string numStr = x.ToString();
        char[] charArray = numStr.ToCharArray();
        bool isNegative = false;
        if (charArray[0] == '-') {
            isNegative = true;
            Array.Copy(charArray, 1, charArray, 0, charArray.Length - 1);
            Array.Resize(ref charArray, charArray.Length - 1);
        }
        Array.Reverse(charArray);
        string reversedString = new string(charArray);
        int result;
        if (int.TryParse(reversedString, out result)) {
            return isNegative ? -result : result;
        } else {
            return 0;
        }
    }
}
