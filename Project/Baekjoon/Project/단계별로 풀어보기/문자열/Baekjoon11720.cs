// 숫자의 합
// https://www.acmicpc.net/problem/11720

using System;

public class Baekjoon11720
{
    public Baekjoon11720 ()
    {
        Console.ReadLine ();
        string str = Console.ReadLine ();
        int sum = 0;
        for (int i = 0; i < str.Length; i++)
        {
            sum += str[i] - 48;
        }
        Console.WriteLine(sum);
    }
}