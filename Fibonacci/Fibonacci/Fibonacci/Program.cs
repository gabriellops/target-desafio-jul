Console.WriteLine("Digite um número:");
int input;

if (int.TryParse(Console.ReadLine(), out input) && input >= 0)
    VerificarFibonacci(input);
else
    Console.WriteLine("Por favor, insira um número válido não negativo.");

static void VerificarFibonacci(int input)
{
    int a = 0, b = 1;

    if (input == a || input == b)
    {
        Console.WriteLine("O número informado pertence à sequência Fibonacci");
        return;
    }

    while (b < input)
    {
        int temp = a + b;
        a = b;
        b = temp;
    }
    
    if (b == input)
        Console.WriteLine("O número informado pertence a sequência Fibonacci");
    else
        Console.WriteLine("O número informado não pertence a sequência Fibonacci");

    Console.ReadLine();
}
