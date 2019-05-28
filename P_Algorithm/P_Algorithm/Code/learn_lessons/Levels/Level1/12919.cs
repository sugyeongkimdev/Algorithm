using System.Linq;

// 서울에서 김서방 찾기
// https://programmers.co.kr/learn/courses/30/lessons/12919

namespace P_Algorithm_12919 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution(new[]{ "Jane" , "Kim" });
        }
    }

    //====================================//

    public class Solution {
        public string solution(string[] seoul) {
            int index = seoul.Select((s, i) => new { s, i }).First(x => x.s == "Kim").i;
            return "김서방은 " + index + "에 있다";
        }
    }

}
