﻿
// 짝수와 홀수
// https://programmers.co.kr/learn/courses/30/lessons/12937

using System;

public class Programmers12937
{
    public Programmers12937 ()
    {
        new Solution ().solution (10);
    }

    //====================================//
    public class Solution
    {
        public string solution (int num)
        {
            Console.WriteLine (num & 1);
            // 나머지값
            //return num % 2 == 0 ? "Even" : "Odd";

            // 논리연산
            return (int)(num & 1) == 0 ? "Even" : "Odd";
        }
    }
    //====================================//
}