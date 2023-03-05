

using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

int HammingWeight(uint n)
{
    int onesCounter = 0;
    
    while( n > 0)
    {
        uint myNum = n & 1;

        if (myNum == 1)
            onesCounter++;

        n >>= 1;
    }

    return onesCounter;
}

uint x = 1011u;
 
Console.WriteLine(HammingWeight(x));