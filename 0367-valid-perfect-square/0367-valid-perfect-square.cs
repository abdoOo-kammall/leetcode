public class Solution {
    public bool IsPerfectSquare(int num) {
        long left = 1, right = num;

        while (left <= right) {
            long mid = (left + right) / 2;
            long square = mid * mid;

            if (square == num) return true;
            if (square > num)
                right = mid - 1;
            else
                left = mid + 1;
        }

        return false;
    }
}
