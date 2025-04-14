using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string para inverter: ");
        string original = Console.ReadLine() ?? "desenvolvedor"; //caso seja setado um valor nulo, ele é substituido pela palavra padrão "desenvolvedor

        string changed = RevertString(original);

        Console.WriteLine("String invertida: " + changed);
    }

    static string RevertString(string text)
    {
        char[] textChanged = new char[text.Length];

        int j = 0;
        for (int i = text.Length - 1; i >= 0; i--)
        {
            textChanged[j] = text[i];
            j++;
        }

        return new string(textChanged);
    }
}
