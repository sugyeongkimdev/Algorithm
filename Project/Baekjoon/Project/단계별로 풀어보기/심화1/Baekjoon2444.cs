// 별 찍기 - 7
// https://www.acmicpc.net/problem/2444

using System;

public class Baekjoon2444
{
    public Baekjoon2444 ()
    {
        int num = int.Parse (Console.ReadLine ());
        int size = num * 2 - 1;

        for (int i = 0; i < size; i++)
        {
            int space = Math.Abs (num - (i + 1));
            for (int j = 0; j < space; j++)
            {
                Console.Write (" ");
            }
            int star = (num - space) * 2 - 1;
            for (int j = 0; j < star; j++)
            {
                Console.Write ("*");
            }
            Console.WriteLine ();
        }
    }
}