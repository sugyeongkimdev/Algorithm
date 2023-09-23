// 빠른 A+B
// https://www.acmicpc.net/problem/15552

using System;
using System.IO;

public class Baekjoon15552
{
    public Baekjoon15552 ()
    {
        using (var sr = new StreamReader (Console.OpenStandardInput ()))
        {
            var sb = new System.Text.StringBuilder ();
            for (int i = int.Parse (sr.ReadLine ()); i > 0; i--)
            {
                string[] str = sr.ReadLine ().Split ();
                sb.Append (int.Parse (str[0]) + int.Parse (str[1])).AppendLine ();
            }
            Console.WriteLine (sb);
        }
    }
}