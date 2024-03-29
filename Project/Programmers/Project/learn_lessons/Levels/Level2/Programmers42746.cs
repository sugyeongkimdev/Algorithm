﻿
// 가장 큰 수
// https://programmers.co.kr/learn/courses/30/lessons/42746

using System.Collections.Generic;

public class Programmers42746
{
    public Programmers42746 ()
    {
        new Solution ().solution (new[] { 3, 30, 34, 5, 9 });
    }

    //====================================//
    public class Solution
    {
        public string solution (int[] numbers)
        {
            List<string> list = new List<int> (numbers).ConvertAll (i => i.ToString ());

            list.Sort ((x, y) => { return (y + x).CompareTo (x + y); });

            if (list[0].Equals ("0"))
            {
                return "0";
            }

            return string.Join ("", list);
        }
    }
    //====================================//
}