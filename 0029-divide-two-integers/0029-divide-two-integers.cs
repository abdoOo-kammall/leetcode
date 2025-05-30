public class Solution {
    public int Divide(int dividend, int divisor) {
        if (dividend == int.MinValue && divisor == -1 || dividend == int.MaxValue && divisor == 1   )
            return int.MaxValue;
        if (dividend == int.MinValue && divisor == 1   )
            return int.MinValue  ;


        bool flagD1 = false; 
        bool flagD2 = false; 

        if (divisor < 0) {  flagD2 = true; } 
        if (dividend < 0) { flagD1 = true; }
       
        long a = Math.Abs((long)dividend);
        long b = Math.Abs((long)divisor);
        int ans = 0;

        while (a - b >= 0) {
            int x = 0;
            while (a - (b << (x + 1)) >= 0) {
                x++;
            }
            ans += 1 << x;
            a -= b << x;
        }




        return (flagD1 == flagD2) ? ans : -ans;
    }
}
