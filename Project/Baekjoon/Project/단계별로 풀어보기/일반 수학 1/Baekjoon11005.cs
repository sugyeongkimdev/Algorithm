// 진법 변환 2
// https://www.acmicpc.net/problem/11005

using System;

public class Baekjoon11005
{
    public Baekjoon11005 ()
    {
        string[] arr = Console.ReadLine ().Split ();
        int value = int.Parse (arr[0]);
        int b = int.Parse (arr[1]);

        var sb = new System.Text.StringBuilder ();
        while (value >= b)
        {
            int r = value % b;
            value /= b;

            sb.Insert (0, GetChar (r));
        }
        sb.Insert (0, GetChar (value));

        char GetChar (int n)
        {
            return n >= 0 && n <= 9 ? (char)('0' + n) : (char)('A' + n - 10);
        }

        Console.WriteLine (sb);

    }
}