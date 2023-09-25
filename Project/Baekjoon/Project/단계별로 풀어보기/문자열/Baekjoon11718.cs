// 그대로 출력하기
// https://www.acmicpc.net/problem/11718

using System;

public class Baekjoon11718
{
    public Baekjoon11718 ()
    {
        var sb = new System.Text.StringBuilder ();
        string str;
        while (string.IsNullOrWhiteSpace (str = Console.ReadLine ()) == false)
        {
            sb.AppendLine (str);
        }
        Console.Write(sb);
    }
}