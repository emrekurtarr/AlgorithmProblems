

int p, c, m, b, z = 0;

Console.WriteLine(z);

int perfectTeam(string skills)
{
    //skills = String.Concat(skills.OrderBy(x => x));
    int p = 0;
    int c = 0;
    int m = 0;
    int b = 0;
    int z = 0;


    foreach (char item in skills)
    {
        switch (item)
        {
            case 'p':
                p ++;
                break;
            case 'c':
                c++;
                break;
            case 'm':
                m++;
                break;
            case 'b':
                b++;
                break;
            case 'z':
                z++;
                break;

            default: break;
        }
    }

    if (p == 0 || c == 0 || m == 0 || b == 0 || z == 0)
        return 0;

    List<int> numberOfSkills = new List<int>();
    numberOfSkills.Add(p);
    numberOfSkills.Add(c);
    numberOfSkills.Add(m);
    numberOfSkills.Add(b);
    numberOfSkills.Add(z);

    int min = numberOfSkills.First();

    foreach (int item in numberOfSkills)
    {
        if (min > item)
        {
            min = item;
        }
    }

    return min;
}

List<int> array = new List<int>();
array.Add(1);

array.Add(2);
array.Add(3);

for (int i = 0; i < length; i++)
{

}

Convert.ToInt64()

    while (temp >= 1)
{

    initialVal = temp;

    foreach (int item in arr)
    {

        if (item + initialVal < 1)
        {
            temp++;
            break;
        }
        initialVal += item;

        flag++;
    }

    if (flag == countOfArr)
    {
        break;
    }

}

