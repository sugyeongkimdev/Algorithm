// 약수 구하기
// https://www.acmicpc.net/problem/2501

using System;

public class Baekjoon2501
{
    public Baekjoon2501 ()
    {
        var arr = Console.ReadLine ().Split ();
        int p = int.Parse (arr[0]);
        int q = int.Parse (arr[1]);

        int i = 0;
        int hit = 0;
        while (true)
        {
            if (i >= p)
            {
                i = 0;
                break;
            }
            if (p % ++i == 0)
            {
                if (q == ++hit)
                {
                    break;
                }
            }
        }
        Console.WriteLine (i);
    }
}