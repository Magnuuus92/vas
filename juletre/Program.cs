class Program
{
    static void Main()
    {
        int height = 6;

        for (int i = 0; i < height; i++)
        {
            for (int s = 0; s < height - i - 1; s++)
            {
                Console.Write(" ");
            }

            for (int x = 0; x < (2 * i + 1); x++)
            {
                Console.Write("x");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < height - 2; i++)
            Console.Write(" ");

        Console.WriteLine(" x");
    }
}