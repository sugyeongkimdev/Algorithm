// 알파벳 찾기
// https://www.acmicpc.net/problem/10809

using System;
using System.Linq;

public class Baekjoon10809
{
    public Baekjoon10809 ()
    {
        int[] arr = Enumerable.Repeat (-1, 'z' - 'a' + 1).ToArray ();
        string str = Console.ReadLine ();
        for (int i = 0; i < str.Length; i++)
        {
            int index = str[i] - 'a';
            if (arr[index] == -1)
            {
                arr[index] = i;
            }
        }
        Console.WriteLine (string.Join (" ", arr));
    }
}