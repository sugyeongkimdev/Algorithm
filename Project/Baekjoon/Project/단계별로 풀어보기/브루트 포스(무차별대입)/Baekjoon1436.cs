// 영화감독 숌
// https://www.acmicpc.net/problem/1436

using System;

public class Baekjoon1436
{
    public Baekjoon1436 ()
    {
        int N = int.Parse (Console.ReadLine ());
        int hit = 1;
        int num = 666;
        string str;
        while (hit < N)
        {
            num++;
            str = num.ToString ();
            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str[i] == '6' && str[i + 1] == '6' && str[i + 2] == '6')
                {
                    hit++;
                    break;
                }
            }
        }
        Console.WriteLine (num);
    }
}