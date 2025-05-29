public class Solution {
    public int StrStr(string haystack, string needle) {
            for(int i = 0 ; i < haystack.Length ; i++) 
            {
                 int c = 1 ; 
                 int j = 1 ;
                if (needle[0] == haystack[i]){
                int index = i+1 ; 

                while (j < needle.Length && index < haystack.Length && haystack[index] == needle[j]) {
                    if (needle[j] == haystack[index]) {
                        c++ ; //sad  /// sadness
                        index++;
                        j++;
                    }
                    
                
                        
                }
                if (c==needle.Length) return i ;}
            }
            

        
        return -1 ;
    }
}