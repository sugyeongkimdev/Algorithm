﻿using System.Linq;
using System.Collections.Generic;

// 제일 작은 수 제거하기
// https://programmers.co.kr/learn/courses/30/lessons/12935

namespace P_Algorithm_12935 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution(new[] { 10 });
        }
    }

    //====================================//

    public class Solution {
        public int[] solution(int[] arr) {
            // Linq
            //var list = arr.ToList();
            //if(arr.Length <= 1) {
            //    return new[]{ -1 };
            //} else {
            //    var remove = list.Min();
            //    list.Remove(list.Min(m => m));
            //    return list.ToArray();
            //}

            // Linq 제외시
            var value = new List<int>(arr);
            var sort = new List<int>(arr);
            sort.Sort();
            value.Remove(sort[0]);
            if(value.Count <= 0) {
                return new int[] { -1 };
            }
            return value.ToArray();
        }
    }
}
