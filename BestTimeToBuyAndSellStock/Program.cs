

// Best Time to Buy and Stock

int MaxProfit(int[] prices)
{

    while ()
    {
        int firstTimeMinValue = prices.Min();
        int firstTimeMaxValue = prices.Max();

        int maxProfitFirstMethod = 0;
        int maxProfitSecondMethod = 0;

        if (Array.IndexOf(prices, firstTimeMinValue) > Array.IndexOf(prices, firstTimeMaxValue))
        {
            while(prices.Length > 1)
            {
                int minValue = prices.Min();
                int maxValue = prices.Max();
                if (Array.IndexOf(prices, minValue) > Array.IndexOf(prices, maxValue))
                {
                    prices = prices.Skip(Array.IndexOf(prices, maxValue)).ToArray();
                    continue;
                }
                maxProfitFirstMethod = maxValue - minValue;    
            }
            
        }
        else(Array.IndexOf(prices, firstTimeMinValue) < Array.IndexOf(prices, firstTimeMaxValue))
        {
            while(prices.Length )
        }


    }
    
    


}


Console.WriteLine(MaxProfit(new int[] { 2, 4, 1 }));






