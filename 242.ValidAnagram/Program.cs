

using System.Text;

bool IsAnagram(string s, string t)
{
    #region Solution 1

    //Dictionary<char,int> dic = new Dictionary<char,int>();

    //foreach (char item in s)
    //{
    //	if (dic.ContainsKey(item))
    //	{
    //		dic[item] = dic[item] + 1;
    //	}
    //	else
    //	{
    //		dic.Add(item, 1);
    //	}
    //}

    //foreach (char item in t)
    //{
    //	if (!dic.ContainsKey(item)) {

    //		return false;
    //       }
    //	else
    //	{
    //           if (dic[item] > 1)
    //           {
    //               dic[item]--;
    //           }
    //           else
    //               dic.Remove(item);
    //       }


    //}

    //if (!dic.Any())
    //	return true;

    //return false;

    #endregion

    #region Solution 2 
    // Because there are 26 chars from a to z. 
    int[] charCounts = new int[26];

    if (s.Length != t.Length)
        return false;

    for (int i = 0; i < s.Length; i++)
    {
        charCounts[s[i] - 'a']++;
        charCounts[t[i] - 'a']--;
    }

    foreach (int count in charCounts)
    {
        if (count != 0)
            return false;
    }

    return true;

    #endregion
}

Console.WriteLine(IsAnagram("anagram", "nagaram"));