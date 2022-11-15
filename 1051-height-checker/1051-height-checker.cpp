class Solution {
public:
    int heightChecker(vector<int>& heights) {
        
        vector<int>nums(heights.size());
        for (int i = 0 ; i < heights.size ( ) ; i++)
        {
            nums[i] = heights[i];
        }
        sort (heights.begin() , heights.end());
        int counter = 0 ;
       for (int i = 0 ; i < heights.size ( ) ; i++)
        {
           if ( nums[i] != heights[i])
                counter++;
            
        }
        return counter ; 
    }
};