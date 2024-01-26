public class Solution {
    public int MySqrt(int x) {
        double squareRoot = Math.Sqrt(x);
        int result = (int)Math.Floor(squareRoot);
        return result;
    }
}
