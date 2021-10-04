
// 예산
// https://programmers.co.kr/learn/courses/30/lessons/12982

using System;

public class Solution12982
{
    public Solution12982()
    {
        new Solution().solution(new[] { 1, 3, 2, 5, 4 }, 9);
    }

    //====================================//
    public class Solution
    {
        public int solution(int[] d, int budget)
        {
            int money = budget;
            int count = 0;
            int[] sort = (int[])d.Clone();
            Array.Sort(sort);
            for (int i = 0; i < sort.Length; i++)
            {
                if (money - sort[i] < 0)
                {
                    break;
                }
                money -= sort[i];
                count++;
            }
            return count;
        }
    }
    //====================================//
}