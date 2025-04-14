using System;

class Program
{
    static void Main()
    {

        Dictionary<string, double> statesValor = new Dictionary<string, double>()
        {
            {"SP", 67836.43},
            {"RJ", 36678.66},
            {"MG", 29229.88},
            {"ES", 27165.48},
            {"Outros", 19849.53}
        };

        double total = 0;
        foreach (var valor in statesValor.Values)
        {
            total += valor;
        }

        Console.WriteLine("Percentual de cada estado:\n");

        foreach (var item in statesValor)
        {
            double percentual = (item.Value / total) * 100;
            Console.WriteLine($"{item.Key}: {percentual.ToString("F2")}%");
        }
    }
}
