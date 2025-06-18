using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {
        string res =Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();
        for (int i = 0 , j = res.Length-1 ; i< j; i++,j--) {
            if (res[i] == res[j])continue;
            else  return false;

        }
        return true;

    }
}