public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0) return "";

        var shortest = strs.OrderBy(s => s.Length).First();
        int j = 0;

        for (int i = 0; i < shortest.Length; i++) {
            var prefix = shortest.Substring(0, i + 1);
            var counter = strs.Where(s => s.StartsWith(prefix)).Count();

            if (counter == strs.Length)
                j = i + 1;
            else
                break;
        }

        return shortest.Substring(0, j);
    }
}
