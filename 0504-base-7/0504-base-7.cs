public class Solution {
    public string ConvertToBase7(int num) {
        if (num == 0) return "0";
        int d = num ;
        if(num < 0) num*=-1 ;
        string s  = "" ; 
        while (num != 0){
            int x  = num % 7 ;
            s=x.ToString() + s ;
            num= num / 7 ;
        }
        if (d > 0  )
        return s ; 
        else 
        return "-"+s;
    }
}