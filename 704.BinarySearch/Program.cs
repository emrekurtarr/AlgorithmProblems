

int Search(int[] nums, int target)
{
    int left = 0;
    int right = nums.Length - 1;

    int mid = (right + 1) / 2;

    while ( left <= right)
    {
        if(nums[mid] == target)
            return mid;
        else if (nums[mid] < target)
        {
            left = mid + 1;
        }
        else if (nums[mid] > target)
        {
            right = mid - 1;
        }

        mid = left + ((right - left) / 2);

    }
    
    return -1;
    
}



int[] array = new int[] { -1, 0, 3, 5, 9,12,18,27,56,65};

Console.WriteLine(Search(array,2));
Console.ReadLine();