// 주사위 세개
// https://www.acmicpc.net/problem/2480

using System;
using System.Linq;

public class Baekjoon2480
{
    public Baekjoon2480 ()
    {
        string[] arr = Console.ReadLine ().Split ();
        var dic = arr.GroupBy (x => x).ToDictionary (x => int.Parse (x.Key), x => x.Count ());
        int add = 0;
        int multiple = 100;
        int dice;
        if (dic.Count () == 1)
        {
            add = 10000;
            multiple = 1000;
            dice = dic.First (x => x.Value == 3).Key;
        }
        else if (dic.Count () == 2)
        {
            add = 1000;
            dice = dic.First (x => x.Value == 2).Key;
        }
        else
        {
            dice = dic.Max (x => x.Key);
        }
        Console.WriteLine (add + dice * multiple);
    }
}