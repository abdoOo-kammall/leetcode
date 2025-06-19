public class Solution {
    public int TitleToNumber(string columnTitle) {
        int res = 0;
        double J = 0;
        for (int i = columnTitle.Length - 1; i >= 0; i--) {
            res += (int)(Math.Pow(26.0, J) * (columnTitle[i] - 'A' + 1));
            J++;
        }
        return res;
    }
}
