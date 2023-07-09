using FaturamentoDiario;
using Newtonsoft.Json;

var json = File.ReadAllText(@"C:\target-desafio-jul\FaturamentoDiario\FaturamentoDiario\FaturamentoDiario\dados.json");

List<Dados> dados = JsonConvert.DeserializeObject<List<Dados>>(json);

List<decimal> nums = new List<decimal>();

foreach (Dados dado in dados)
{
    if (dado.Valor > 0)
        nums.Add(dado.Valor);
}

Console.WriteLine($"O menor valor de faturamento ocorrido em um dia do mês: {nums.Min()}");
Console.WriteLine($"O maior valor de faturamento ocorrido em um dia do mês: {nums.Max()}");
//Console.WriteLine($"O número de dias no mês em que o valor do faturamento diário superou a média mensal foi de: {}");

Console.ReadLine();