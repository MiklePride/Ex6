class program
{
    static void Main(string[] args)
    {
        int picturesRow = 3;
        int picturesAmount = 52;
        int amountRow = picturesAmount / picturesRow;
        int amountExtraPictures = picturesAmount % picturesRow;
        Console.WriteLine("Количество заполненых стен = {0} \nКоличество лишних картинок = {1}", amountRow, amountExtraPictures);
    }
}
