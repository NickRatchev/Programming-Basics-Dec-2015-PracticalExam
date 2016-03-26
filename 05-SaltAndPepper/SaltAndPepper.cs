using System;

class SaltAndPepper
{
    static void Main()
    {
        ulong dishesNumber = ulong.Parse(Console.ReadLine());

        string[] currentCommand = Console.ReadLine().Split(' ');

        while (currentCommand[0] != "end")
        {
            int step = int.Parse(currentCommand[1]);

            if (currentCommand[0] == "salt")
            {
                for (int i = 0; i < 64; i+=step)
                {
                    ulong mask = (ulong)1 << i;
                    dishesNumber = dishesNumber & (~mask);
                }
            }
            else
            {
                for (int i = 0; i < 64; i+=step)
                {
                    ulong mask = (ulong)1 << i;
                    dishesNumber = dishesNumber & (~mask);
                    dishesNumber = dishesNumber | mask;
                }
            }
            currentCommand = Console.ReadLine().Split(' ');
        }
        Console.WriteLine(dishesNumber);
    }
}