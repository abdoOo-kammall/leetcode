public class Solution {
    public bool IsPerfectSquare(int num) {
        if (num < 1) return false;

        double log10 = Math.Log10(num);
        double logHalf = log10 / 2.0;

        double root = Math.Pow(10, logHalf); // this should be the square root
        int rounded = (int)Math.Round(root);

        return rounded * rounded == num;
    }
}
