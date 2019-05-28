using System;

// 정수 제곱근 판별
// https://programmers.co.kr/learn/courses/30/lessons/12934


namespace P_Algorithm_12934 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution(121);
        }
    }

    //====================================//
    public class Solution {
        public long solution(long n) {
            Console.WriteLine(Math.Sqrt(n));
            if(int.TryParse(Math.Sqrt(n).ToString(), out int value)) {
                return (long)Math.Pow(value + 1, 2);
            } else {
                return -1;
            }
        }
    }

}
