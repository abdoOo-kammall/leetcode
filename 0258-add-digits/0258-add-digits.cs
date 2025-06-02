public class Solution {
    public int AddDigits(int num) {
        if (num== 0) return 0 ;
        else if (num >= 1 && num <=9)return num;
        int c= 0 ; 
        //38
        while (num > 9) {
             int total = 0 ;
            while (num > 0) {
            total += num % 10 ;//38
            num/=10;
            }
            num = total ;
           

        }
        return num ;

    }
}