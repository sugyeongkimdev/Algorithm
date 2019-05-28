﻿using System;

// 두 정수 사이의 합
// https://programmers.co.kr/learn/courses/30/lessons/12912

namespace P_Algorithm_12912 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution(3, 5);
            //new Solution().solution(-5, -3);
        }
    }

    //====================================//

    public class Solution {
        public long solution(int a, int b) {
            long sum = 0;
            int max = Math.Max(a,b);
            int min = Math.Min(a,b);
            for(int i = min; i <= max; i++) {
                sum += i;
            }
            return sum;
        }
    }

}
