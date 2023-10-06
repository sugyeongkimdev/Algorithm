// 체스판 다시 칠하기
// https://www.acmicpc.net/problem/1018

using System;

public class Baekjoon1018
{
    public Baekjoon1018 ()
    {
        var read = Console.ReadLine ().Split ();
        int w = int.Parse (read[1]);
        int h = int.Parse (read[0]);
        bool[,] board = new bool[w, h];

        for (int y = 0; y < h; y++)
        {
            var str = Console.ReadLine ();
            for (int x = 0; x < w; x++)
            {
                board[x, y] = str[x] == 'W' ? true : false;
            }
        }

        int result = 8 * 8;
        for (int y = 0; y <= h - 8; y++)
        {
            for (int x = 0; x <= w - 8; x++)
            {
                var hit = HitCheck8x8 (x, y);
                result = Math.Min (result, hit);
            }
        }

        Console.WriteLine (result);

        int HitCheck8x8 (int startX, int startY)
        {
            bool b = board[startX, startY];
            int hit1 = 0;
            int hit2 = 0;
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (b != board[startX + x, startY + y])
                    {
                        hit1++;
                    }
                    b = !b;
                    if (b != board[startX + x, startY + y])
                    {
                        hit2++;
                    }
                }
                b = !b;
            }
            return Math.Min (hit1, hit2);
        }
    }
}