Console.WriteLine("Digite uma palavra para ser invertida:");
var input = Console.ReadLine().Trim();

Inverter(input);
Console.ReadLine();

static void Inverter(string input)
{
    string str = "";

    for (int i = input.Length - 1; i >= 0; i--)
        str += input[i];

    Console.WriteLine($"Palavra invertida: {str}");
}