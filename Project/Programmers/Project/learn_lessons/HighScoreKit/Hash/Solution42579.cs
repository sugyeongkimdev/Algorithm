
// 베스트앨범
// https://programmers.co.kr/learn/courses/30/lessons/42579

using System.Linq;

public class Solution42579
{
    public Solution42579()
    {
        new Solution().solution(
            new[] { "classic", "pop", "classic", "classic", "pop" },
            new[] { 500, 600, 150, 800, 2500 });
    }

    //====================================//
    public class Solution
    {
        public int[] solution(string[] genres, int[] plays)
        {
            int[] answer = Enumerable.Range(0, genres.Length)
                // 무명 생성 후 타입, 재생수 정렬
                .Select(i => new { i, g = genres[i], p = plays[i] })
                .OrderBy(t => t.g)
                .ThenByDescending(t => t.p)
                // 타입 그룹핑
                .GroupBy(t => t.g)
                // 타입 총 합 정렬
                .OrderByDescending(t => t.Sum(a => a.p))
                // 상위 2개 가져오기
                .Select(t => t.Take(2))
                // 상위 i 배열 캐스팅
                .SelectMany(t => t)
                .Select(t => t.i)
                .ToArray();

            return answer;
        }
    }
    //====================================//
}