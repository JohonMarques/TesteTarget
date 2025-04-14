using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número Inteiro para verificar se pertence à sequência de Fibonacci: ");
        string input = Console.ReadLine()!;

        if (int.TryParse(input, out int informedNumber))
        {
            bool pertence = Fibonacci(informedNumber);

            if (pertence)
                Console.WriteLine($"{informedNumber} PERTENCE à sequência de Fibonacci.");
            else
                Console.WriteLine($"{informedNumber} NÃO PERTENCE à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine("Digite um número inteiro.");
        }
    }

    static bool Fibonacci(int number)
    {
        int a = 0;
        int b = 1;

        while (a <= number)
        {
            if (a == number)
                return true;

            int nextNumber = a + b;
            a = b;
            b = nextNumber;
        }

        return false;
    }
}
