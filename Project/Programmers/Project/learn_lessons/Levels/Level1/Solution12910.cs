
// 나누어 떨어지는 숫자 배열
// https://programmers.co.kr/learn/courses/30/lessons/12910

using System.Linq;

public class Solution12910
{
    public Solution12910()
    {
        new Solution().solution(new[] { 5, 9, 7, 10 }, 5);
        //new Solution().solution(new[] { 2, 36, 1, 3 }, 1);
        //new Solution().solution(new[] { 3, 2, 6 }, 10);
    }

    //====================================//
    public class Solution
    {
        public int[] solution(int[] arr, int divisor)
        {
            var search = arr.Where(a => a % divisor == 0);
            if (search.Count() == 0)
            {
                return new[] { -1 };
            }
            else
            {
                var list = search.ToList();
                list.Sort();
                return list.ToArray();
            }
        }
    }
    //====================================//

}
