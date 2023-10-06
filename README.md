
### learn algorithm

<!--
<hr/> 굵은 줄
<br/> 공간
-->


[MD작성법](https://gist.github.com/ihoneymon/652be052a0727ad59601#%EA%B3%B5%ED%86%B5-%EB%A7%88%ED%81%AC%EB%8B%A4%EC%9A%B4-markdown-%EC%9E%91%EC%84%B1%EB%B2%95)   
[구현](https://velog.io/@hyun0820/%EC%BD%94%EB%94%A9%ED%85%8C%EC%8A%A4%ED%8A%B8-%EA%B5%AC%ED%98%84Implementation-%EC%9C%A0%ED%98%95)

#

> + [프로그래머스](https://programmers.co.kr/)
> + [백준](https://www.acmicpc.net/)
>   + [(BOJ 작동 원리)](https://www.acmicpc.net/blog/view/55)
>   + [삼성 SW 역량 테스트 기출 문제](https://www.acmicpc.net/workbook/view/1152)
>   + [구현/실버](https://solved.ac/search?query=%23implementation+*s)
> + [릿코드](https://leetcode.com/)   
> #

> ## [알고리즘 공부 방법](https://velog.io/@guide333/%EC%95%8C%EA%B3%A0%EB%A6%AC%EC%A6%98-%EA%B3%B5%EB%B6%80-%EB%B0%A9%EB%B2%95)
> + [시리즈:수학인듯 과학아닌 공학같은 컴퓨터과학/알고리즘 기초](https://librewiki.net/wiki/%EC%8B%9C%EB%A6%AC%EC%A6%88:%EC%88%98%ED%95%99%EC%9D%B8%EB%93%AF_%EA%B3%BC%ED%95%99%EC%95%84%EB%8B%8C_%EA%B3%B5%ED%95%99%EA%B0%99%EC%9D%80_%EC%BB%B4%ED%93%A8%ED%84%B0%EA%B3%BC%ED%95%99/%EC%95%8C%EA%B3%A0%EB%A6%AC%EC%A6%98_%EA%B8%B0%EC%B4%88)
> + [VisuAlgo(정렬, 트리 등 원리 시각화)](https://visualgo.net/en)
> + [시간 복잡도(Time Complexity)](https://hanamon.kr/%EC%95%8C%EA%B3%A0%EB%A6%AC%EC%A6%98-time-complexity-%EC%8B%9C%EA%B0%84-%EB%B3%B5%EC%9E%A1%EB%8F%84/)
> #

> ## [정렬](https://namu.wiki/w/%EC%A0%95%EB%A0%AC%20%EC%95%8C%EA%B3%A0%EB%A6%AC%EC%A6%98)
> + 버블정렬() [ O(n(n-1)/2) ... O(n²) ]
>   + 쓰는 이유 : 구현이 간단해서, 효율은 최악에 가까움
>```
>   void BubbleSort (int[] arr)
>   {
>       for (int i = 0; i < arr.Length - 1; i++)
>       {
>           for (int j = 0; j < arr.Length - i - 1; j++)
>           {
>               if (arr[j] > arr[j + 1])
>               {
>                   int tmp = arr[j];
>                   arr[j] = arr[j + 1];
>                   arr[j + 1] = tmp;
>               }
>           }
>       }
>   }
>```

```c#
    // 2차 배열 상자 90도 회전 (정사각형만 가능)
    int boxSize = 3;
    int[,] box = new int[,]{
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 }};
    int[,] rotate90Box = new int[3,3];
    //    7, 4, 1,
    //    8, 5, 2,
    //    9, 6, 3,
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            rotate90Box[i,j] = box[boxSize - j - 1, i];
            Console.Write ($"{rotate90Box[i, j]}, ");
        }
        Console.WriteLine ();
    }
```

```c#
    //    *
    //   ***
    //  *****
    // *******
    //*********
    // *******
    //  *****
    //   ***
    //    *
    int num = 5;
    for (int i = num - 1; i > -num; i--)
    {
        string blank = new string (' ', Math.Abs (i));
        string star = new string ('*', (2 * num) - 1 - (2 * Math.Abs (i)));
        Console.WriteLine (blank + star);
    }
```

```c#
    // 10진법으로 변환 ((n)bit -> (10))
    string str = "ZZZZZ";    // 1111(2) ~ ZZZZ(36)
    int bit = 36;            // 2 ~ 36
    double num = 0;
    for (int i = 0; i < str.Length; i++)
    {
        num += Math.Pow (bit, i) * GetNum (str[i]);
        // or
        // num += num * (bit - 1) + GetNum (str[i]);
    }
    Console.WriteLine (num); // 60466175

    int GetNum (char c)
    {
        return c >= '0' && c <= '9' ? c - '0' : c - 'A' + 10;
    }
```
```c#
    // n진법으로 변환 (10 -> (n)bit)
    int value = "60466175"; // ZZZZZ(36) 10진법 값
    int bit = 36;           // 2 ~ 36
    var sb = new System.Text.StringBuilder ();
    while (value >= b)
    {
        int r = value % bit;
        value /= bit;

        sb.Insert (0, GetChar (r));
    }
    sb.Insert (0, GetChar (value)); 
    Console.WriteLine (sb);  // ZZZZZ

    int GetNum (char c)
    {
        return c >= '0' && c <= '9' ? c - '0' : c - 'A' + 10;
    }
```
