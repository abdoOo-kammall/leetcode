class Solution {
public:
    bool backspaceCompare(string s, string t) {
        stack<char>st1 ,st2;
        for (int i =0 ; i <s.size();i++){
            if (s[i]!='#')
                st1.push(s[i]);
             else
             {
                 if (!st1.empty())
                st1.pop();
             }
        }
        for (int i =0 ; i <t.size();i++){
            if (t[i]!='#')
                st2.push(t[i]);
            else
               {
                 if (!st2.empty())
                st2.pop();
             }
            
        }
        string one="" ;
        while (!st1.empty()){
            one+=st1.top();
            st1.pop();
        }
         string two="" ;
        while (!st2.empty()){
            two+=st2.top();
            st2.pop();
        }
        if (one == two)
            return true;
        return false;
        
    }
};