class program
{
    static void Main(string[] args)
    {
        int picturesInRow = 3;
        int pictures = 52;
        int filledRows = pictures / picturesInRow;
        int extraPictures = pictures % picturesInRow;
        Console.WriteLine("Количество заполненых стен = {0}\nКоличество лишних картинок = {1}", filledRows, ExtraPictures);
    }
}
