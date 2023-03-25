
Solution sl = new Solution();

Console.WriteLine(sl.FirstBadVersion(160));




public class VersionControl
{
    public bool IsBadVersion(int x)
    {
        if (x >= 68)
            return true;

        return false;
    }
}






/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        int left = 0;
        int right = n;

        while( right > left + 1)
        {
            int mid = left + (right - left) / 2;
            
            //Below code throws time limit exceed exception. Because n could be 2 to power of 31 which is the max value of integer data type
            //int mid = (left + right) / 2
            

            if (!IsBadVersion(mid))
                left = mid;
            else
                right = mid;
        }

        return right;
        
        
    }
}