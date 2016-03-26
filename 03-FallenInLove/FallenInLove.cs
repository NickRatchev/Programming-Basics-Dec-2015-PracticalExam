using System;

class FallenInLove
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("#" + "".PadRight(i, '~') + "#" +
                              "".PadRight(2 * (n - i), '.') + "#" + "".PadRight(2 * i, '.') + "#" +
                              "".PadRight(2 * (n - i), '.') + "#" + "".PadRight(i, '~') + "#");
        }

        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine("".PadRight(2 * i + 1, '.') +
                              "#" + "".PadRight(n - i, '~') + "#" +
                              "".PadRight(2 * (n - i), '.') +
                              "#" + "".PadRight(n - i, '~') + "#" +
                              "".PadRight(2 * i + 1, '.'));
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("".PadRight(2 * (n + 1), '.') + "##" + "".PadRight(2 * (n + 1), '.'));
        }
    }
}