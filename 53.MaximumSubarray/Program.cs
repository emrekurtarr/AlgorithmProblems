

int[] numbers = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

Console.WriteLine(MaxSubArray(numbers));


int MaxSubArray(int[] nums)
{

	#region O(n^2) solution
	//int max = nums[0];


	//for (int i = 0; i < nums.Length; i++)
	//{
	//	int sum = 0;
	//	for (int j = i; j < nums.Length; j++)
	//	{
	//		sum += nums[j];

	//		if (max < sum)
	//			max = sum;
			
	//	}
	//}

	//return max;

	#endregion

	#region O(n) solution

	int sum = nums[0];
	int max = nums[0];

	for (int i = 1; i < nums.Length; i++)
	{
		if (nums[i] > sum + nums[i])
			sum = nums[i];
		else
			sum += nums[i];

		max = Math.Max(max, sum);
	}

	return max;

    #endregion





}