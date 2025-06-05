public class Solution {
    public bool IsPalindrome(int x) {
        int div = 0  ,palindorme=0 , ispalindorme=x ;
        while (x > 0) {//121
                div = x %10 ;
                palindorme = palindorme * 10 + div ;//12
                x/=10;
        }
    return palindorme == ispalindorme;
    }
}