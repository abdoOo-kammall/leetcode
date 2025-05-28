public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int c = int.MaxValue;
        if (strs == null || strs.Length == 0) return "";
        if (strs.Length == 1) return strs[0];

        for (int i = 0; i < strs.Length - 1; i++) {
            int currentCount = 0;
            for (int j = 0; j < Math.Min(strs[i].Length, strs[i + 1].Length); j++) {
                if (strs[i][j] == strs[i + 1][j]) {
                    currentCount++;
                } else {
                    break;
                }
            }
            c = Math.Min(c, currentCount);
            if (c == 0) break;
        }

        return strs[0].Substring(0, c);
    }
}
