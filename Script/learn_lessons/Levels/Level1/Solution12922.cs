
// 수박수박수박수박수박수?
// https://programmers.co.kr/learn/courses/30/lessons/12922

using System.Linq;

public class Solution12922
{
    public Solution12922()
    {
        new Solution().solution(3);
    }

    //====================================//
    public class Solution
    {
        public string solution(int n)
        {
            string str = string.Concat(Enumerable.Repeat("수박", n / 2 + 1));
            return str.Remove(str.Length - (n % 2 == 0 ? 2 : 1));
        }
    }
    //====================================//
}