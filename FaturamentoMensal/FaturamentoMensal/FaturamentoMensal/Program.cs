var estadoSp = 67836.43;
var estadoRj = 36678.66;
var estadoMg = 29229.88;
var estadoEs = 27165.48;
var outrosEstados = 19849.53;
var faturamentoTotal = estadoSp + estadoRj + estadoMg + estadoEs + outrosEstados;

var porcentagemSp = (estadoSp / faturamentoTotal) * 100;
var porcentagemRj = (estadoRj / faturamentoTotal) * 100;
var porcentagemMg = (estadoMg / faturamentoTotal) * 100;
var porcentagemEs = (estadoEs / faturamentoTotal) * 100;
var porcentagemOutrosEstados = (outrosEstados / faturamentoTotal) * 100;

Console.WriteLine($"O faturamento da distribuidora no Estado de SP representa {porcentagemSp:0.00}% do faturamento total");
Console.WriteLine($"O faturamento da distribuidora no Estado de RJ representa {porcentagemRj:0.00}% do faturamento total");
Console.WriteLine($"O faturamento da distribuidora no Estado de MG representa {porcentagemMg:0.00}% do faturamento total");
Console.WriteLine($"O faturamento da distribuidora no Estado de ES representa {porcentagemEs:0.00}% do faturamento total");
Console.WriteLine($"O faturamento da distribuidora nos demais Estados representa {porcentagemOutrosEstados:0.00}% do faturamento total");
Console.ReadLine();