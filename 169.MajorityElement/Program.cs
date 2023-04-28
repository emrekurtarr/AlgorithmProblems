// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] arr = new int[] { 3,3,4 };

Console.WriteLine(MajorityElement(arr));



int MajorityElement(int[] nums)
{
    int rep = nums.Length / 2;
    Dictionary<int, int> dic = new Dictionary<int, int>();

    foreach (int item in nums)
    {
        if (dic.ContainsKey(item))
            dic[item]++;
        else
            dic.Add(item, 1);
    }

    int maxValue = dic.Values.Max();

    
    return dic.FirstOrDefault(x => x.Value == maxValue).Key;


}