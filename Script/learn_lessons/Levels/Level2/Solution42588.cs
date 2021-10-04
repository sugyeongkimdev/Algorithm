
// 탑
// https://programmers.co.kr/learn/courses/30/lessons/42588

public class Solution42588
{
    public Solution42588()
    {
        new Solution().solution(new[] { 6, 9, 5, 7, 4 });
    }

    //====================================//
    public class Solution
    {
        public int[] solution(int[] heights)
        {
            int[] arr = new int[heights.Length];
            for (int top = heights.Length - 1; top >= 0; top--)
            {
                for (int left = top - 1; left >= 0; left--)
                {
                    if (heights[top] < heights[left])
                    {
                        arr[top] = left + 1;
                        break;
                    }
                }
            }
            return arr;
        }
    }
    //====================================//
}