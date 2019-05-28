
// 가운데 글자 가져오기
// https://programmers.co.kr/learn/courses/30/lessons/12901

namespace P_Algorithm_12903 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution("abcde");
            //new Solution().solution("qwer");
        }
    }

    //====================================//

    public class Solution {
        public string solution(string s) {
            if(s.Length < 2) {
                return s;
            } else if(s.Length % 2 == 0) {
                return s[s.Length / 2 - 1].ToString() + s[s.Length / 2].ToString();
            } else {
                return s[s.Length / 2].ToString();
            }
        }
    }

}
