// 단어의 개수
// https://www.acmicpc.net/problem/1152

using System;

public class Baekjoon1152
{
    public Baekjoon1152 ()
    {
        //string[] split = Console.ReadLine ().Split (new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //Console.WriteLine (split.Length);

        string str = Console.ReadLine ();
        int cur = 0;
        int result = 0;
        bool flip = true;
        while (cur < str.Length)
        {
            if (str[cur++] == ' ')
            {
                flip = true;
                continue;
            }
            if (flip)
            {
                flip = false;
                result++;
            }
        }
        Console.WriteLine (result);
    }
}