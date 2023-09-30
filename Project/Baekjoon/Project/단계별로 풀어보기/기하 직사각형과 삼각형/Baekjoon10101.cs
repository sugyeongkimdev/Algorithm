// 삼각형 외우기
// https://www.acmicpc.net/problem/10101

using System;

public class Baekjoon10101
{
    public Baekjoon10101 ()
    {
        int a = int.Parse (Console.ReadLine ());
        int b = int.Parse (Console.ReadLine ());
        int c = int.Parse (Console.ReadLine ());
        if (a == 60 && b == 60 && c == 60)
        {
            Console.WriteLine ("Equilateral");
            return;
        }
        if (a + b + c == 180)
        {
            if (a == b || a == c || c == b)
            {
                Console.WriteLine ("Isosceles");

            }
            else
            {
                Console.WriteLine ("Scalene");
            }
        }
        else
        {
            Console.WriteLine ("Error");
        }
    }
}