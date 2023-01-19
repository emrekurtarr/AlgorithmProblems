

// Best Time to Buy and Stock

int MaxProfit(int[] prices)
{

    int leftPointer = 0;
    int rightPointer = 1;
    int maxProfit = 0;

    while(rightPointer < prices.Length)
    {
        if (prices[leftPointer] > prices[rightPointer])
        {
            leftPointer = rightPointer;
            rightPointer++;
            continue;
        }

        maxProfit = Math.Max(maxProfit, prices[rightPointer] - prices[leftPointer]);
        rightPointer++;
    }

    return maxProfit;
}


Console.WriteLine(MaxProfit(new int[] { 2, 4, 1 }));






