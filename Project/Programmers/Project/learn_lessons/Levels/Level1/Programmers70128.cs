
// 내적
// https://programmers.co.kr/learn/courses/30/lessons/70128

using System.Linq;

public class Programmers70128
{
    public Programmers70128 ()
    {
        new Solution ().solution (new[] { 1, 2, 3, 4 }, new[] { -3, -1, 0, 2 });
        //new Solution().solution(new[] { -1, 0, 1 }, new[] { 1, 0, -1 });
    }

    //====================================//
    public class Solution
    {
        public int solution (int[] a, int[] b)
        {
            // 각 배열의 숫자끼리 곱한 후 총합 계산
            int answer = a.Select ((aNum, i) => aNum * b[i]).Sum ();
            return answer;
        }
    }
    //====================================//
}