


int[,] myArray = new int[,] { { 1, 1, 1 }, { 1, 1, 0 }, { 1, 0, 1 } };

myArray = FloodFill(myArray, 1, 1, 2);

Console.ReadLine();


int[,] FloodFill(int[,] image, int sr, int sc, int color)
{
    int uBound0 = image.GetUpperBound(0);
    int uBound1 = image.GetUpperBound(1);

    if (sr > uBound0 || sc > uBound1)
        return image;

    int startingPixel = image[sr, sc];
    image[sr, sc] = color;

    if (sr - 1 <= uBound0 && sr -1 >= 0 && image[sr - 1, sc] == startingPixel && image[sr - 1, sc] != color)
    {
        FloodFill(image, sr - 1, sc, color);
    }


    if (sr + 1 <= uBound0 && sr + 1 >= 0 && image[sr + 1, sc] == startingPixel && image[sr + 1, sc] != color )
    {
        FloodFill(image, sr + 1, sc, color);
    }


    if (sc - 1 >= 0 && sc - 1 <= uBound1 && image[sr, sc - 1] == startingPixel && image[sr, sc - 1] != color)
    {
        FloodFill(image, sr, sc - 1, color);
    }

    if (sc + 1 <= uBound1 && sc + 1 >= 0 && image[sr, sc + 1] == startingPixel && image[sr, sc + 1] != color)
    {
        FloodFill(image, sr, sc + 1, color);
    }
    return image;
}
