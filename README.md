
### learn algorithm

</br>

[MD작성법](https://gist.github.com/ihoneymon/652be052a0727ad59601#%EA%B3%B5%ED%86%B5-%EB%A7%88%ED%81%AC%EB%8B%A4%EC%9A%B4-markdown-%EC%9E%91%EC%84%B1%EB%B2%95)   
[구현](https://velog.io/@hyun0820/%EC%BD%94%EB%94%A9%ED%85%8C%EC%8A%A4%ED%8A%B8-%EA%B5%AC%ED%98%84Implementation-%EC%9C%A0%ED%98%95)

</br>

> + [프로그래머스](https://programmers.co.kr/)
> + [백준](https://www.acmicpc.net/)
>   + [(BOJ 작동 원리)](https://www.acmicpc.net/blog/view/55)
>   + [삼성 SW 역량 테스트 기출 문제](https://www.acmicpc.net/workbook/view/1152)
>   + [구현/실버](https://solved.ac/search?query=%23implementation+*s)
> + [릿코드](https://leetcode.com/)

</br>

> ## 1. [알고리즘 공부 방법](https://velog.io/@guide333/%EC%95%8C%EA%B3%A0%EB%A6%AC%EC%A6%98-%EA%B3%B5%EB%B6%80-%EB%B0%A9%EB%B2%95)
> #### 1.2 [VisuAlgo(정렬, 트리 등 원리 시각화)](https://visualgo.net/en)
> #### 1.1 [시리즈:수학인듯 과학아닌 공학같은 컴퓨터과학/알고리즘 기초](https://librewiki.net/wiki/%EC%8B%9C%EB%A6%AC%EC%A6%88:%EC%88%98%ED%95%99%EC%9D%B8%EB%93%AF_%EA%B3%BC%ED%95%99%EC%95%84%EB%8B%8C_%EA%B3%B5%ED%95%99%EA%B0%99%EC%9D%80_%EC%BB%B4%ED%93%A8%ED%84%B0%EA%B3%BC%ED%95%99/%EC%95%8C%EA%B3%A0%EB%A6%AC%EC%A6%98_%EA%B8%B0%EC%B4%88)

<hr/>

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
