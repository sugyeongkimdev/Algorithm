using System;

// 문자열을 정수로 바꾸기
// https://programmers.co.kr/learn/courses/30/lessons/12925

namespace P_Algorithm_12925 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution("1234");
        }
    }

    //====================================//

    public class Solution {
        public int solution(string s) {
            // return int.Parse(s); 이건 너무 쉬워서 안쓰고 작성

            int simbol = s[0] == '+' || s[0] == '-' ? 1 : 0;
            int value = 0;
            const int ascii = 48;
            for(int i = simbol; i < s.Length; i++) {
                value += (s[i] - ascii) * (int)Math.Pow(10, s.Length - i - 1);
            }

            return simbol == 0 ? value : s[0] == '+' ? value : -value;
        }
    }

}
