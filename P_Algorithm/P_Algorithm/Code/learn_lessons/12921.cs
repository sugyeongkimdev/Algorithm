
// 소수 찾기
// https://programmers.co.kr/learn/courses/30/lessons/12921
// https://blog.naver.com/ddo009/220707562118?viewType=pc

namespace P_Algorithm_12921 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution(10);
        }
    }

    //====================================//

    public class Solution {
        public int solution(int n) {
            var list = new bool[n + 1];
			int result = 0;
            for(int i = 2; i <= n; i++) {
                if(list[i] == false) {
					result++;
                    for(int j = 0; j <= n; j += i) {
						list[j] = true;
                    }
                }
            }
			return result;
        }
    }

}
