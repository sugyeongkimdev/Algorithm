using System.Linq;

// 문자열 내림차순으로 배치하기
// https://programmers.co.kr/learn/courses/30/lessons/12917

namespace P_Algorithm_12917 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution("Zbcdefg");
        }
    }

    //====================================//

    public class Solution {
        public string solution(string s) {
            return new string(s.OrderByDescending(str => str).ToArray());
        }
    }

}
