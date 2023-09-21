
// 하샤드 수
// https://programmers.co.kr/learn/courses/30/lessons/12947

public class Solution12947
{
    public Solution12947()
    {
        new Solution().solution(10);
    }

    //====================================//
    public class Solution
    {
        public bool solution(int x)
        {
            int sum = 0;
            for (int i = 0; i < x.ToString().Length; i++)
            {
                sum += int.Parse(x.ToString()[i].ToString());
            }
            return x % sum == 0;
        }
    }
    //====================================//
}