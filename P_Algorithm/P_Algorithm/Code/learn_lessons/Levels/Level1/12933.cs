using System;
using System.Linq;

// 정수 내림차순으로 배치하기
// https://programmers.co.kr/learn/courses/30/lessons/12933


namespace P_Algorithm_12933 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution(118372);
        }
    }

    //====================================//

    public class Solution {
        public long solution(long n) {
            // linq
            //var arr = n.ToString().OrderByDescending(x => x);
            //return long.Parse(new string(arr.ToArray()));

            // linq 안쓰고
            var arr = n.ToString().ToCharArray();
            Array.Sort(arr);
            Array.Reverse(arr);
            return long.Parse(new string(arr));
        }
    }

}
