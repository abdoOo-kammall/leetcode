public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length ) return false ;
        int[] arr1 = new int [27];
        int[] arr2 = new int [27];
        for(int i = 0 ; i<s.Length;i++) {

            arr1[s[i] - 'a']++;
        }
        for(int i = 0 ; i<t.Length;i++) {

            arr2[t[i]-'a']++;
        }
for (int i = 0 ; i<27 ; i++) {
        if (arr1[i] != arr2[i]) return false;
}
return true;
    }
}