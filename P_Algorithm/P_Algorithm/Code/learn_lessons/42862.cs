using System.Collections.Generic;
using System.Linq;

// 체육복
// https://programmers.co.kr/learn/courses/30/lessons/42862

namespace P_Algorithm_42862 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution(5, new[] { 2, 4 }, new[] { 1, 3, 5 });
            //new Solution().solution(5, new[] { 2, 4 }, new[] { 3 });
        }
    }

    //====================================//

    public class Solution {
        public int solution(int n, int[] lost, int[] reserve) {
            Dictionary<int, int> dir = new Dictionary<int, int>();

            for(int i = 0; i < n; i++) {
                dir[i] = 1;
            }
            for(int i = 0; i < lost.Length; i++) {
                dir[lost[i] - 1]--;
            }
            for(int i = 0; i < reserve.Length; i++) {
                dir[reserve[i] - 1]++;
            }

            for(int i = 0; i < n; i++) {
                if(dir[i] == 0) {
                    if(dir.ContainsKey(i - 1) && dir[i - 1] > 1) {
                        dir[i]++;
                        dir[i - 1]--;
                    }
                    if(dir.ContainsKey(i + 1) && dir[i + 1] > 1) {
                        dir[i]++;
                        dir[i + 1]--;
                    }
                }
            }
            return dir.Where(s => s.Value > 0).Count();
        }
    }

}
