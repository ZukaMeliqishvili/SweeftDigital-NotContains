static int NotContains(int[] arr)
{
    Array.Sort(arr);
    int answer = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == answer)
            answer++;
    }
    return answer;
}