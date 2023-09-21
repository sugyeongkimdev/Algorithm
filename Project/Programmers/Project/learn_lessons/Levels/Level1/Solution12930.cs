
// 이상한 문자 만들기
// https://programmers.co.kr/learn/courses/30/lessons/12930

public class Solution12930
{
    public Solution12930()
    {
        new Solution().solution("try hello world");
    }

    //====================================//
    public class Solution
    {
        public string solution(string s)
        {
            string str = "";
            foreach (var item in s.Split(' '))
            {
                var arr = item.ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        arr[i] = char.ToUpper(arr[i]);
                    }
                    else
                    {
                        arr[i] = char.ToLower(arr[i]);
                    }
                }
                str += new string(arr) + ' ';
            }
            return str.Substring(0, str.Length - 1);
        }
    }
    //====================================//
}