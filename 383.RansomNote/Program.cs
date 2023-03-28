


Console.WriteLine(CanConstruct("aa", "aab"));


bool CanConstruct(string ransomNote, string magazine)
{
    //List<char> charList = new List<char>();

    //foreach (char item in magazine)
    //{
    //    charList.Add(item);
    //}

    //foreach (char item in ransomNote)
    //{
    //    if (!charList.Where(x => x.Equals(item)).Any())
    //        return false;
    //    else
    //        charList.Remove(item);

    //}
    //magazine.Remove()
    //return true;

    ////////////////////////////////////////////////////////////////////////////


    // Faster way

    int[] array = new int[26];

    foreach (char item in magazine)
    {
        array[item - 'a']++;
    }

    foreach (char item in ransomNote)
    {
        array[item - 'a']--;
    }

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            return false;
    }

    return true;

}