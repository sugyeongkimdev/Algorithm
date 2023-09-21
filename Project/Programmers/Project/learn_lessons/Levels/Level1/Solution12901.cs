
// 2016년
// https://programmers.co.kr/learn/courses/30/lessons/12901

using System;

public class Solution12901
{
    public Solution12901()
    {
        new Solution().solution(5, 24);
    }

    //====================================//
    public class Solution
    {
        public string solution(int a, int b)
        {
            string[] STR_WEEK = new[] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };
            return STR_WEEK[(int)new DateTime(2016, a, b).DayOfWeek];
        }
    }
    //====================================//
}