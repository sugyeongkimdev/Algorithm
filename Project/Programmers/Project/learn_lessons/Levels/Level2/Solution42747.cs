
// 큰 수 만들기
// https://programmers.co.kr/learn/courses/30/lessons/42747

using System;

public class Solution42747
{
    public Solution42747()
    {
        new Solution().solution(new[] { 3, 0, 6, 1, 5 });
    }

    //====================================//
    public class Solution
    {
        public int solution(int[] citations)
        {
            Array.Sort(citations);
            Array.Reverse(citations);

            for (int i = 0; i < citations.Length; i++)
            {
                if (citations[i] <= i)
                {
                    return i;
                }
            }
            return citations.Length;
        }
    }
    //====================================//
}