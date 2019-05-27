using System.Collections.Generic;
using System.Linq;

// K번째수
// https://programmers.co.kr/learn/courses/30/lessons/42748

namespace P_Algorithm_42748 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution(
                new[] { 1, 5, 2, 6, 3, 7, 4 },
                new[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } });
        }
    }

    //====================================//

    public class Solution {
        public int[] solution(int[] array, int[,] commands) {
            List<int> a = new List<int>();
            for(int i = 0; i < commands.GetLength(0); i++) {
                List<int> list = array.Skip(commands[i, 0] - 1).Take(commands[i, 1] - commands[i, 0] + 1).ToList();
                list.Sort();
                a.Add(list[commands[i, 2] - 1]);
            }
            return a.ToArray();
        }
    }

}
