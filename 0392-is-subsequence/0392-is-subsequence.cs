public class Solution {
    public bool IsSubsequence(string s, string t) {
        int pointer1=0 ;
         if (s.Length==0) return true ;
        for (int i = 0 ; i < t.Length ; i++){
                // i = pointer2;
            if (s[pointer1] == t[i])
                pointer1++;
        if (pointer1 == s.Length) return true ;

            }
        return false ;
    }
}