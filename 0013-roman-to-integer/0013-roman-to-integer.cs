public class Solution {
    public int RomanToInt(string s) {
        int total = 0;
        int pre = 0;
        int result = 0 ; 
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == 'I') result = 1;
            else if (s[i] == 'V') result = 5;
            else if (s[i] == 'X') result = 10;
            else if (s[i] == 'L') result = 50;
            else if (s[i] == 'C') result = 100;
            else if (s[i] == 'D') result = 500;
            else if (s[i] == 'M') result = 1000;

                if (result > pre ) {
                    total += result - 2 * pre ;
                }
                else total += result ;
            pre = result;

        }

        return total;
    }
}
