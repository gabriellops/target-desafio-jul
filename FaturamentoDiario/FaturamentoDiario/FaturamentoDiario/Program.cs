using FaturamentoDiario;
using Newtonsoft.Json;

var caminho = @"C:\target-desafio-jul\FaturamentoDiario\FaturamentoDiario\FaturamentoDiario\dados.json";
if (!File.Exists(caminho))
{
    Console.WriteLine("Arquivo não encontrado.");
    return;
}

var json = File.ReadAllText(caminho);
List<Dados> dados = JsonConvert.DeserializeObject<List<Dados>>(json);

var valoresValidos = dados.Where(d => d.Valor > 0).Select(d => d.Valor).ToList();

decimal menorValor = valoresValidos.Min();
decimal maiorValor = valoresValidos.Max();
decimal mediaMensal = valoresValidos.Average();
int diasAcimaDaMedia = valoresValidos.Count(v => v > mediaMensal);

Console.WriteLine($"O menor valor de faturamento ocorrido em um dia do mês: {menorValor:C}");
Console.WriteLine($"O maior valor de faturamento ocorrido em um dia do mês: {maiorValor:C}");
Console.WriteLine($"O número de dias no mês em que o valor do faturamento diário superou a média mensal foi de: {diasAcimaDaMedia}");

Console.ReadLine();
