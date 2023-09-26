// 벌집
// https://www.acmicpc.net/problem/2292

using System;

public class Baekjoon2292
{
    public Baekjoon2292 ()
    {
        // 1-6, 2-12, 3-18, 4-24
        // 겹수가 6의 배수로 늘어남
        int c = int.Parse (Console.ReadLine ()) - 1;
        int cell = 1;
        int dis = 0;
        while (cell <= c)
        {
            dis++;
            cell += dis * 6;
        }
        Console.Write (dis + 1);
    }
}