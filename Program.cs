using System;

class Program
{
    static void Main()
    {
        int baseNumber = GetNumber("Podaj podstawę: ");
        int exponent = GetNumber("Podaj wykładnik: ");

        int result = Power(baseNumber, exponent);

        Console.WriteLine($"{baseNumber} do potęgi {exponent} wynosi {result}.");

        Console.ReadKey();
    }

    static int Power(int baseNumber, int exponent)
    {
        if (exponent == 0)
            return 1;

        int result = baseNumber;

        for (int i = 1; i < exponent; i++)
        {
            result *= baseNumber;
        }

        return result;
    }

    static int GetNumber(string message)
    {
        Console.Write(message);
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("Błędne dane. Podaj liczbę naturalną.");
            Console.Write(message);
        }

        return number;
    }
}
