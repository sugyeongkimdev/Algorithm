// 큰 수 만들기
// https://programmers.co.kr/learn/courses/30/lessons/42747

// 기사를 보고 식을 만들고 다른사람 글도 읽었지만 이해가 힘듬
// http://www.ibric.org/myboard/read.php?id=270333&Board=news

using System;

namespace P_Algorithm_42747 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution(new[]{3, 0, 6, 1, 5});
        }
    }

    //====================================//
    public class Solution {
        public int solution(int[] citations) {
            Array.Sort(citations);
            Array.Reverse(citations);

            for(int i = 0; i < citations.Length; i++) {
                if(citations[i] <= i) {
                    return i;
                }
            }
            return citations.Length;
        }
    }

}
