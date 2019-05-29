// 평균 구하기
// https://programmers.co.kr/learn/courses/30/lessons/12944

using System.Linq;

namespace P_Algorithm_12944 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution(new [] { 1, 2, 3, 4 });
        }
    }

    //====================================//

    public class Solution {
        public double solution(int[] arr) {
            //return arr.Average();

            double sum = 0;
            for(int i = 0; i < arr.Length; i++) {
                sum += arr[i];
            }
            return sum/arr.Length;
        }
    }
}
