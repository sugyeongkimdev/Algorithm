// 자연수 뒤집어 배열로 만들기
// https://programmers.co.kr/learn/courses/30/lessons/12932

namespace P_Algorithm_12932 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution(12345);
        }
    }

    //====================================//

    public class Solution {
        public int[] solution(long n) {
            string str = n.ToString();
            int[] arr = new int[str.Length];
            for(int i = 0; i < str.Length; i++) {
                arr[arr.Length - 1 - i] = int.Parse(str[i].ToString());
            }
            return arr;
        }
    }

}
