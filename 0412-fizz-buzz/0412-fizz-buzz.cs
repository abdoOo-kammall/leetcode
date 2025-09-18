public class Solution {
    public IList<string> FizzBuzz(int n) {
        IList<string> l = new List<string>();
        for (int i = 1; i <= n; i++) {
            if (i % 3 == 0 && i % 5 == 0)
                l.Add("FizzBuzz");
            else if (i % 5 == 0)
                l.Add("Buzz");
            else if (i % 3 == 0)
                l.Add("Fizz");
            else
                l.Add(i.ToString());
        }
        return l;
    }
}
