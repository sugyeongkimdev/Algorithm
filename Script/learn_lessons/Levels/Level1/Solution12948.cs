
// 핸드폰 번호 가리기
// https://programmers.co.kr/learn/courses/30/lessons/12948

public class Solution12948
{
    public Solution12948()
    {
        new Solution().solution("01033334444");
    }

    //====================================//
    public class Solution
    {
        public string solution(string phone_number)
        {
            var arr = phone_number.ToCharArray();
            for (int i = 0; i < arr.Length - 4; i++)
            {
                arr[i] = '*';
            }
            return new string(arr);
        }
    }
    //====================================//
}