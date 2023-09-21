
// 모의고사
// https://programmers.co.kr/learn/courses/30/lessons/42840

using System;
using System.Collections.Generic;

public class Solution42840
{
    public Solution42840 ()
    {
        new Solution ().solution (new[] { 1, 2, 3, 4, 5 });
        //new Solution().solution(new[] { 1, 3, 2, 4, 2 });
    }

    //====================================//
    public class Solution
    {
        public int[] solution (int[] answers)
        {
            int[][] hitMap = new int[][] {
                new[]{ 1,2,3,4,5,},
                new[]{ 2,1,2,3,2,4,2,5},
                new[]{ 3,3,1,1,2,2,4,4,5,5} };
            int[] hit = new int[hitMap.Length];
            List<int> an = new List<int> ();

            for (int i = 0; i < answers.Length; i++)
            {
                for (int hitIndex = 0; hitIndex < hitMap.Length; hitIndex++)
                {
                    if (answers[i] == hitMap[hitIndex][i % hitMap[hitIndex].Length])
                    {
                        hit[hitIndex]++;
                    }
                }
            }
            int max = Math.Max (hit[0], Math.Max (hit[1], hit[2]));

            if (hit[0] == max)
            {
                an.Add (1);
            }
            if (hit[1] == max)
            {
                an.Add (2);
            }
            if (hit[2] == max)
            {
                an.Add (3);
            }

            return an.ToArray ();
        }
    }
    //====================================//
}