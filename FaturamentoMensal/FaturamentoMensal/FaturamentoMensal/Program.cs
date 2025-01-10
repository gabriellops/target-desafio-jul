var faturamentoPorEstado = new Dictionary<string, double>
{
    { "SP", 67836.43 },
    { "RJ", 36678.66 },
    { "MG", 29229.88 },
    { "ES", 27165.48 },
    { "Outros", 19849.53 }
};

double faturamentoTotal = 0;
foreach (var faturamento in faturamentoPorEstado.Values)
{
    faturamentoTotal += faturamento;
}

Console.WriteLine("Percentual de representação por estado no faturamento total:\n");
foreach (var estado in faturamentoPorEstado)
{
    double percentual = (estado.Value / faturamentoTotal) * 100;
    Console.WriteLine($"{estado.Key}: {percentual:0.00}%");
}

Console.ReadLine();
