// 진법 변환
// https://www.acmicpc.net/problem/2745

using System;

public class Baekjoon2745
{
    public Baekjoon2745 ()
    {
        string[] arr = Console.ReadLine ().Split ();
        string str = arr[0];
        int b = int.Parse (arr[1]);

        double num = 0;
        for (int i = 0; i < str.Length; i++)
        {
            num += num * (b - 1) + GetNum (str[i]);
            // or
            //num += Math.Pow (b, i) * GetNum (str[i]);
        }

        int GetNum (char c)
        {
            return c >= '0' && c <= '9' ? c - '0' : c - 'A' + 10;
        }

        Console.WriteLine (num);
    }
}