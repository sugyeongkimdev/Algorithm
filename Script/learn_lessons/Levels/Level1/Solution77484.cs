
// 로또의 최고 순위와 최저 순위
// https://programmers.co.kr/learn/courses/30/lessons/77484

using System;
using System.Linq;

public class Solution77484
{
    public Solution77484()
    {
        new Solution().solution(new[] { 44, 1, 0, 0, 31, 25 }, new[] { 31, 10, 45, 1, 6, 19 });
        //new Solution().solution(new[] { 0, 0, 0, 0, 0, 0 }, new[] { 38, 19, 20, 40, 15, 25] });
        //new Solution().solution(new[] { 45, 4, 35, 20, 3, 9 }, new[] { 20, 9, 3, 45, 4, 35 });
    }

    //====================================//
    public class Solution
    {
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int zeroCount = lottos.Count(num => num == 0);
            int matCount = lottos.Intersect(win_nums).Count();
            int[] answer = new[] { 7 - ClampRank(matCount + zeroCount), 7 - ClampRank(matCount) };
            return answer;
        }

        // 순위 1 ~ 6 고정
        private int ClampRank(int val)
        {
            return Math.Min(Math.Max(val, 1), 6);
        }
    }
    //====================================//
}


