public class Solution {
    public string ConvertToTitle(int columnNumber) {
        string[] englishGroups = new string[]
        {
            "A", "B", "C", "D", "E", "F", "G",
            "H", "I", "J", "K", "L", "M", "N",
            "O", "P", "Q", "R", "S", "T", "U",
            "V", "W", "X", "Y", "Z"
        };

        string result = "";

        while (columnNumber > 0)
        {
            columnNumber--; 
            int remainder = columnNumber % 26;
            result = englishGroups[remainder] + result;
            columnNumber /= 26;
        }

        return result;
    }
}
