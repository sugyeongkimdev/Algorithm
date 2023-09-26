// 분수찾기
// https://www.acmicpc.net/problem/1193

using System;

public class Baekjoon1193
{
    public Baekjoon1193 ()
    {
        int count = int.Parse (Console.ReadLine ());
        int cur = count;
        int line = 1;
        while (cur > line)
        {
            cur -= line;
            line++;
        }
        if (line % 2 == 0)
        {
            Console.WriteLine ($"{cur}/{line - cur + 1}");
        }
        else
        {
            Console.WriteLine ($"{line - cur + 1}/{cur}");
        }
    }
}