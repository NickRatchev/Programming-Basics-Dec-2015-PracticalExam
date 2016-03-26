using System;

class PassionDays
{
    static void Main()
    {
        decimal totalMoney = decimal.Parse(Console.ReadLine());
        string currentCommand = string.Empty;
        long purchases = 0;

        do
        {
            currentCommand = Console.ReadLine();
        } while (currentCommand != "mall.Enter");

        currentCommand = Console.ReadLine();

        while (currentCommand != "mall.Exit")
        {
            for (int i = 0; i < currentCommand.Length; i++)
            {
                decimal currentPrice = currentCommand[i];

                if (currentCommand[i] >= 'A' && currentCommand[i] <= 'Z')
                {
                    currentPrice = currentPrice * 0.5m;
                }
                else if (currentCommand[i] >= 'a' && currentCommand[i] <= 'z')
                {
                    currentPrice = currentPrice * 0.3m;
                }
                else if (currentCommand[i] == '%')
                {
                    currentPrice = totalMoney * 0.5m;
                }
                else if (currentCommand[i] == '*')
                {
                    currentPrice = 0m;
                    totalMoney += 10m;
                }

                if (currentCommand[i] != '*' && currentPrice <= totalMoney && totalMoney !=0)
                {
                    totalMoney -= currentPrice;
                    purchases += 1;
                }
            }
            currentCommand = Console.ReadLine();
        }

        if (purchases == 0)
        {
            Console.WriteLine("No purchases. Money left: {0:F2} lv.", totalMoney);
        }
        else
        {
            Console.WriteLine("{0} purchases. Money left: {1:F2} lv.", purchases, totalMoney);
        }
    }
}