

int maxNetwork(List<int> speed,int minComps,long speedThres)
{

    int addedSpeed = 0;
    int maxNetworkCount = 0;
    int speedAmount = Convert.ToInt32(speedThres);

    for (int i = 0; i < speed.Count; i++)
    {
        addedSpeed += speed[i];

        if (addedSpeed >= speedAmount)
        {
            maxNetworkCount++;
            addedSpeed = 0;
        }
    }

    return maxNetworkCount;
}

OutMethod(out int a);

Console.WriteLine(a);
static void OutMethod(out int x)
{
    x = 100;
}