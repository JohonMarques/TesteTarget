using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.Json;

public class DadoFaturamento
{
    public int dia { get; set; }
    public double valor { get; set; }
}

class Program
{
    static void Main()
    {
        string path = "./data/dados.json";
        string json = File.ReadAllText(path);

        List<DadoFaturamento> jsonData = JsonSerializer.Deserialize<List<DadoFaturamento>>(json);

        double soma = 0;
        int diasComValor = 0;
        double menor = double.MaxValue;
        double maior = double.MinValue;
        int diasAcimaMedia = 0;
        List<double> valoresValidos = new List<double>();

        for (int i = 0; i < jsonData.Count; i++)
        {
            var data = jsonData[i];

            if (data.valor > 0)
            {
                soma += data.valor;
                diasComValor++;

                if (data.valor < menor) menor = data.valor;
                if (data.valor > maior) maior = data.valor;

                valoresValidos.Add(data.valor);
            }
        }

        if (diasComValor == 0)
        {
            Console.WriteLine("Nenhum dia útil com faturamento válido.");
            return;
        }

        double media = soma / diasComValor;

        foreach (var valor in valoresValidos)
        {
            if (valor > media)
                diasAcimaMedia++;
        }

        Console.WriteLine($"Menor valor (dias úteis, exceto zeros): R$ {menor:F2}");
        Console.WriteLine($"Maior valor (dias úteis): R$ {maior:F2}");
        Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaMedia}");
    }
}
