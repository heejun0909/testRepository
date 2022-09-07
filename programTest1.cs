/**/

public class Solution {
    public long solution(int a, int b) {
        if(a < -10000000 || a > 10000000) {
            return 0;
        }

        if(b < -10000000 || b > 10000000) {
            return 0;
        }

        long answer = 0;

        if(a == b)
        {
            return a;
        }
        else if(a < b) 
        {
            int i = a;
            while (i <= b) {
                answer += i;
                i++;
            }
        }
        else if(a > b) 
        {
            int i = b;
            while (i <= a) {
                answer += i;
                i++;
            }
        }


        return answer;
    }
}