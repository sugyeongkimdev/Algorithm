// 수학은 비대면강의입니다
// https://www.acmicpc.net/problem/19532

// ※) 연립방정식
// https://mathbang.net/15#gsc.tab=0
// ※) 가감법
// https://mathbang.net/18#gsc.tab=0

using System;

public class Baekjoon19532
{
    public Baekjoon19532 ()
    {
        // ax+by=c
        // dx+ey=f

        int[] arr = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
        var (a, b, c, d, e, f) = (arr[0], arr[1], arr[2], arr[3], arr[4], arr[5]);

        // 1.무작위 대입법
        //for (int x1 = -999; x1 < 1000; x1++)
        //{
        //    for (int y1 = -999; y1 < 1000; y1++)
        //    {
        //        if ((a * x1 + b * y1 == c) && (d * x1 + e * y1 == f))
        //        {
        //            Console.WriteLine ($"{x1} {y1}");
        //            return;
        //        }
        //    }
        //}

        // 2.연립방정식 가감법

        // 1. 연립방정식 가감법 X 계산식 (각 항에 공통값(e, b)을 넣어 y미지수를 없앤다)
        // 2. 좌항은 좌항끼리 우항은 우항끼리 뺀다
        // aex+bey = ce
        // bdx+bey = bf
        // -> (aex+bey)-(bdx+bey) = ce-bf
        // -> aex+bey-bdx-bey = ce-bf
        // -> aex-bdx = ce-bf
        // -> x(ae-bd) = ce-bf
        // -> x = ce-bf/ae-bd

        // 1. 연립방정식 가감법 Y 계산식 (각 항에 공통값(a, d)을 넣어 x미지수를 없앤다)
        // 2. 좌항은 좌항끼리 우항은 우항끼리 뺀다
        // adx+bdy = cd
        // adx+aey = af
        // -> (adx+bdy)-(adx+aey) = cd-af
        // -> adx+bdy-adx-aey = cd-af
        // -> bdy-aey = cd-af
        // -> y(bd-ae) = cd-af
        // -> y = cd-af/bd-ae

        int x2 = (c * e - b * f) / (a * e - b * d);
        int y2 = (c * d - a * f) / (b * d - a * e);
        Console.WriteLine ($"{x2} {y2}");
    }
}