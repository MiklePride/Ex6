class program
{
    static void Main(string[] args)
    {
        int picturesInRow = 3;
        int pictures = 52;
        int Rows = pictures / picturesInRow;
        int ExtraPictures = pictures % picturesInRow;
        Console.WriteLine("Количество заполненых стен = {0}\nКоличество лишних картинок = {1}", Rows, ExtraPictures);
    }
}
