
// 직사각형 별찍기
// https://programmers.co.kr/learn/courses/30/lessons/12969

using System;

public class Solution12969
{
    public Solution12969()
    {
        new Solution().solution(12);
    }

    //====================================//
    public class Solution
    {
        public void solution(int n)
        {
            string[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            for (int i = 0; i < b; i++)
            {
                Console.WriteLine("{0}", new string('*', a));
            }
        }
    }
    //====================================//
}