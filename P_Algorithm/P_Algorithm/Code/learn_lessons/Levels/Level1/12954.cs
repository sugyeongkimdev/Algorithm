// x만큼 간격이 있는 n개의 숫자
// https://programmers.co.kr/learn/courses/30/lessons/12954

namespace P_Algorithm_12954 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution(2, 5);
        }
    }

    //====================================//

    public class Solution {
        public long[] solution(int x, int n) {
            var arr = new long[n];
            for(int i = 0; i < n; i++) {
                arr[i] = (i + 1) * (long)x;
            }
            return arr;
        }
    }
}
