




int[][] intervals = new int[5][] { 
	new int[] { 1, 2},
    new int[] { 3, 5},
    new int[] { 6, 7},
    new int[] { 8, 10},
    new int[] { 12,16},
};

var x = Insert(intervals, new int[] { 4, 8 });





int[][] Insert(int[][] intervals, int[] newInterval)
{
	List<int[]> myList = new List<int[]>();

    int index = 0;

    while(index < intervals.Length && intervals[index][1] < newInterval[0])
    {
        myList.Add(intervals[index]);
        index++;
    }

    while(index < intervals.Length && intervals[index][0] <= newInterval[1])
    {
        newInterval[0] = Math.Min(newInterval[0], intervals[index][0]);
        newInterval[1] = Math.Max(newInterval[1], intervals[index][1]);
        index++;
    }

    myList.Add(newInterval); 

    while(index < intervals.Length)
    {
        myList.Add(intervals[index]);
        index++;
    }

    return myList.ToArray();
}

