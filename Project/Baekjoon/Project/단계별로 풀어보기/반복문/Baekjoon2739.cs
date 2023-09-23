// 구구단
// https://www.acmicpc.net/problem/2739

using System;

public class Baekjoon2739
{
    public Baekjoon2739 ()
    {
        int x = Console.Read () - 48;
        for (int i = 1; i <= 9; i++)
        {
            Console.WriteLine ($"{x} * {i} = {x * i}");
        }
    }
}