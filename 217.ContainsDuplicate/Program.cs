






bool ContainsDuplicate(int[] nums)
{
	//for (int i = 0; i < nums.Length; i++)
	//{
	//	for (int j = i+1; j < nums.Length; j++)
	//	{
	//		if (nums[i] == nums[j])
	//			return true;
	//	}
	//}

	//return false;


	// 2nd Solution with HashSet
	HashSet<int> myHash = new HashSet<int>();

	for (int i = 0; i < nums.Length; i++)
	{
		if (!myHash.Add(nums[i]))
			return true;

	}

    return false;

	//3rd solution with sorting operation

	Array.Sort(nums);

	for (int i = 1; i < nums.Length; i++)
	{
		if (nums[i - 1] == nums[i])
			return true;
	}

	return false;
	


}

