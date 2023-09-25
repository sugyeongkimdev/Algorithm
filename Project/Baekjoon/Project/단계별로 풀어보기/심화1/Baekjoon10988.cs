// 팰린드롬인지 확인하기
// https://www.acmicpc.net/problem/10988

using System;

public class Baekjoon10988
{
    public Baekjoon10988 ()
    {
        string str = Console.ReadLine ();
        int size = str.Length / 2;
        bool result = true;
        for (int i = 0; i < size; i++)
        {
            if (str[i] != str[str.Length -1 - i])
            {
                result = false;
                break;
            }
        }
        Console.Write (result ? 1 : 0);
    }
}