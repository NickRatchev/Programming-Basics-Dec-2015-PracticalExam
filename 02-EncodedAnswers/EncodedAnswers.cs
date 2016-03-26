using System;

class EncodedAnswers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string letters = "";
        int[] lettersCount = new int[4];
        char currentLetter = 'a';

        for (int i = 0; i < n; i++)
        {
            uint currentNumber = uint.Parse(Console.ReadLine());
            switch (currentNumber % 4)
            {
                case 0:
                    {
                        currentLetter = 'a';
                        lettersCount[0] += 1;
                    }
                    break;
                case 1:
                    {
                        currentLetter = 'b';
                        lettersCount[1] += 1;
                    }
                    break;
                case 2:
                    {
                        currentLetter = 'c';
                        lettersCount[2] += 1;
                    }
                    break;
                case 3:
                    {
                        currentLetter = 'd';
                        lettersCount[3] += 1;
                    }
                    break;
                default:
                    break;
            }
            letters += currentLetter + " ";
        }

        Console.WriteLine(letters);
        Console.WriteLine("Answer A: {0}", lettersCount[0]);
        Console.WriteLine("Answer B: {0}", lettersCount[1]);
        Console.WriteLine("Answer C: {0}", lettersCount[2]);
        Console.WriteLine("Answer D: {0}", lettersCount[3]);
    }
}