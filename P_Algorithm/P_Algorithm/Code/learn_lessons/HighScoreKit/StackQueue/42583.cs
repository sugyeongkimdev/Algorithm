using System;
using System.Collections.Generic;

// 다리를 지나는 트럭
// https://programmers.co.kr/learn/courses/30/lessons/42583

namespace P_Algorithm_42583 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution(2, 10, new int[] { 7, 4, 5, 6 });
            //new Solution().solution(100, 100, new int[] { 10 });
            //new Solution().solution(100, 100, new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 });
        }
    }

    //====================================//

    public class Solution {
        public int solution(int bridge_length, int weight, int[] truck_weights) {
            List<int> bridge = new List<int>(new int[bridge_length]);
            int time = 0;
            int index = 0;
            int cWeight = 0;
            int count = 0;

            while(true) {
                time++;

                if(bridge[0] != 0) {
                    cWeight -= bridge[0];
                    count++;
                    if(count == truck_weights.Length) {
                        break;
                    }
                }

                bridge.RemoveAt(0);

                if(index < truck_weights.Length && weight >= cWeight + truck_weights[index]) {
                    bridge.Add(truck_weights[index]);
                    cWeight += truck_weights[index];
                    index++;
                } else {
                    bridge.Add(0);
                }
            }
            return time;
        }
    }

}
