public class Solution {
    public int MostWordsFound(string[] sentences) {
        int max = -1 ;

        foreach(var word in sentences)
        {
             var words = word.Split(' ');
             if (words.Length > max) max = words.Length ; 
        }
        return max ;
    }
}