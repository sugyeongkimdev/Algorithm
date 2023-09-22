
// 없는 숫자 더하기
// https://programmers.co.kr/learn/courses/30/lessons/86051

using System.Linq;

public class Programmers86051
{
    public Programmers86051 ()
    {
        new Solution ().solution (new[] { 1, 2, 3, 4, 6, 7, 8, 0 });
        //new Solution().solution(new[] { 5, 8, 4, 0, 6, 7, 9 });
    }

    //====================================//
    public class Solution
    {
        public int solution (int[] numbers)
        {
            // 없는 숫자를 모두 더하는 것과 모든 숫자의 총합에서 있는 숫자를 뺀것은 같음
            int sumAll = Enumerable.Range (1, 9).Sum ();
            int answer = sumAll - numbers.Sum ();
            return answer;
        }
    }
    //====================================//
}