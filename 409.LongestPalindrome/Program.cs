

Console.WriteLine(LongestPalindrome("AaaBaaaaa"));


int LongestPalindrome(string s)
{
	int[] letters = new int[52];
	int longestNumber = 0;
	int numberOfOddChar = 0;

	foreach (char item in s)
	{
		if (char.IsUpper(item))
			letters[(item - 'A')+26]++;
		else
			letters[item - 'a']++;
	}


	for (int i = 0; i < letters.Length; i++)
	{
		if (letters[i] % 2 == 0 && letters[i] > 0)
			longestNumber += letters[i];
		else if(letters[i] % 2 == 1 && letters[i] > 0)
		{
            longestNumber += letters[i] - 1;
			numberOfOddChar++;
        }
			
		
		
	}

	if (numberOfOddChar > 0)
		return longestNumber + 1;

	return longestNumber;
}