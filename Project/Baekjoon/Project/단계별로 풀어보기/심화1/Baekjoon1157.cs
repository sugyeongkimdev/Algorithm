// 단어 공부
// https://www.acmicpc.net/problem/1157

using System;

public class Baekjoon1157
{
    public Baekjoon1157 ()
    {
        string str = Console.ReadLine ().ToLower ();
        int[] arr = new int['z' - 'a' + 1];

        for (int i = 0; i < str.Length; i++)
        {
            arr[str[i] - 'a'] += 1;
        }

        int max = 0;
        int index = 0;
        bool same = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                continue;
            }
            if (arr[i] == max)
            {
                same = true;
                continue;
            }
            if (arr[i] > max)
            {
                max = arr[i];
                index = i;
                same = false;
            }
        }
        Console.WriteLine (same ? "?" : (char)(index + 'A'));
    }
}