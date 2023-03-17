

using System.Text;

bool IsPalindrome(string s)
{
    

    s = s.ToLower();
    char[] arr = s.Where(x => (char.IsLetter(x) || char.IsDigit(x))).ToArray();

    StringBuilder builder = new StringBuilder();

    for (int i = arr.Length-1; i >= 0; i--)
    {
        builder.Append(arr[i]);
    }

    string palindrome = builder.ToString();

    if (string.Equals(palindrome, new string(arr)))
        return true;

    return false;
       
}
 

Console.WriteLine(IsPalindrome("0P"));