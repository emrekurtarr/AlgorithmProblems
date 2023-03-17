



Console.WriteLine(MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));





int MaxProfit(int[] prices)
{

	int maxProfit = 0;
	int left = 0;
	int right = 1;

	while(right < prices.Length)
	{
		if(prices[left] > prices[right])
		{
            left = right;
			right++;
			continue;
		}

		int currentProfit = prices[right] - prices[left];

		if(maxProfit < currentProfit)
			maxProfit = currentProfit;

		right++;
	}

	return maxProfit;

}