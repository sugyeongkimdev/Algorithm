// 최대공약수와 최소공배수
// https://programmers.co.kr/learn/courses/30/lessons/12940
// https://wonheesoo.github.io/2018/01/31/%EC%B5%9C%EB%8C%80%EA%B3%B5%EC%95%BD%EC%88%98%EC%99%80-%EC%B5%9C%EC%86%8C%EA%B3%B5%EB%B0%B0%EC%88%98/

namespace P_Algorithm_12940 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution(3, 12);
        }
    }

    //====================================//

    public class Solution {
        public int[] solution(int n, int m) {
            int gcd = GCD(n, m);
            int min = n * m / gcd;

            return new[] { gcd, min };
        }

        int GCD(int a, int b) {
            return b != 0 ? GCD(b, a%b) : a;
        }
    }
}
