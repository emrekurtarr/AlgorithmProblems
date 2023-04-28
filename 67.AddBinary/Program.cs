


using System.Diagnostics.SymbolStore;
using System.Text;

Console.WriteLine(AddBinary("110010","10111"));



string AddBinary(string a, string b)
{
    StringBuilder sb = new StringBuilder();
    StringBuilder sb2 = new StringBuilder();

    int diff = Math.Abs(a.Length - b.Length);

    bool flagOne = false;

    if (a.Length >= b.Length)
    {
        for (int i = 0; i < diff; i++)
        {
            sb.Append('0');
        }

        foreach (char item in b)
        {
            sb.Append(item);
        }

        char[] newStr = sb.ToString().ToCharArray();
        char[] charsA = a.ToCharArray();


        for (int i = newStr.Length-1; i >= 0; i--)
        {
            char toBeAdded = ' ';
             
            if (newStr[i] == '1' && charsA[i] == '0')
            {
                if (flagOne)
                {
                    toBeAdded = '0';
                }
                else
                    toBeAdded = '1';
            }
            else if(newStr[i] == '1' && charsA[i] == '1')
            {
                toBeAdded = flagOne ? '1' : '0';
                flagOne = true;
            }
            else if(newStr[i] == '0' && charsA[i] == '0')
            {
                if (flagOne)
                {
                    toBeAdded = '1';
                    flagOne = false;
                }
                else
                    toBeAdded = '0';

            }
            else if(newStr[i] == '0' && charsA[i] == '1')
            {
                if (flagOne)
                {
                    toBeAdded = '0';
                }
                else
                    toBeAdded = '1';
            }

            sb2.Append(toBeAdded); 
        }

    }
    else
    {
        for (int i = 0; i < diff; i++)
        {
            sb.Append('0');
        }

        foreach (char item in a)
        {
            sb.Append(item);
        }

        char[] newStr = sb.ToString().ToCharArray();
        char[] charsB = b.ToCharArray();


        for (int i = newStr.Length - 1; i >= 0; i--)
        {
            char toBeAdded = ' ';

            if (newStr[i] == '1' && charsB[i] == '0')
            {
                if (flagOne)
                {
                    toBeAdded = '0';
                }
                else
                    toBeAdded = '1';
            }
            else if (newStr[i] == '1' && charsB[i] == '1')
            {
                toBeAdded = flagOne ? '1' : '0';
                flagOne = true;
            }
            else if (newStr[i] == '0' && charsB[i] == '0')
            {
                if (flagOne)
                {
                    toBeAdded = '1';
                    flagOne = false;
                }
                else
                    toBeAdded = '0';

            }
            else if (newStr[i] == '0' && charsB[i] == '1')
            {
                if (flagOne)
                {
                    toBeAdded = '0';
                }
                else
                    toBeAdded = '1';
            }

            sb2.Append(toBeAdded);
        }

    }


    if (flagOne)
        sb2.Append('1');

    char[] result = sb2.ToString().ToCharArray();
    Array.Reverse(result);
    string str = new string(result);

    return str;

}