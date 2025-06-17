public class Solution {
    public bool CheckIfPangram(string sentence) {
        int[] freArr = new int[26];
        for (int i=0 ; i < sentence.Length ; i++) {
            freArr[sentence[i]-'a']++;
        }
        bool flag = true ;
        for (int i = 0 ; i< freArr.Length ; i++) 
        {
            if (freArr[i] >= 1) continue;
            else return false ;
        }
        return flag ;
    }
}