using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {
        string res =new String(s.Where(char.IsLetterOrDigit) .Select(char.ToLower)
        .ToArray());
        for (int i = 0 , j = res.Length-1 ; i< j; i++,j--) {
            if (res[i] == res[j])continue;
            else  return false;

        }
        return true;

    }
}