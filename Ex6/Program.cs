class program
{
    static void Main(string[] args)
    {
        int picturesInARow = 3;
        int picturesAmount = 52;
        Console.WriteLine("Количество заполненых рядов = " + picturesAmount / picturesInARow);
        Console.WriteLine("Количество лишних картинок = " + picturesAmount % picturesInARow); 
    }
}
