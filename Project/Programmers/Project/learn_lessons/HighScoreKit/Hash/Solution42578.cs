
// 위장
// https://programmers.co.kr/learn/courses/30/lessons/42578

using System.Collections.Generic;

public class Solution42578
{
    public Solution42578()
    {
        new Solution().solution(new[,] {
            { "yellowhat", "headgear" },
            { "bluesunglasses", "eyewear" },
            { "green_turban", "headgear" }});

        //new Solution().solution(new[,] {
        //    { "crowmask", "face" },
        //    { "bluesunglasses", "face" },
        //    { "smoky_makeup", "face" }});
    }

    //====================================//
    public class Solution
    {
        public int solution(string[,] clothes)
        {
            int answer = 1;
            Dictionary<string, int> hash = new Dictionary<string, int>();

            // 그룹화
            for (int i = 0; i < clothes.GetLength(0); i++)
            {
                string key = clothes[i, 1];
                hash[key] = hash.ContainsKey(key) ? hash[key] + 1 : 1;
            }

            // 가짓수 = ((x+1) * (y+1) * (z+1)...(n+1)) - 1
            foreach (var item in hash)
            {
                answer *= item.Value + 1;
            }

            return answer - 1;
        }
    }
    //====================================//
}