Console.WriteLine("Digite um número:");
var input = int.Parse(Console.ReadLine());

CalcularSequenciaFibonacci(input);

static void CalcularSequenciaFibonacci(int input)
{
    var fibonacciNums = new List<int> { 0, 1 };

    while (fibonacciNums[fibonacciNums.Count - 1] < input)
    {
        var numAnterior = fibonacciNums[fibonacciNums.Count - 1];
        var numAnterior2 = fibonacciNums[fibonacciNums.Count - 2];

        fibonacciNums.Add(numAnterior + numAnterior2);
    }

    if (fibonacciNums.Contains(input))
        Console.WriteLine("O número informado pertence a sequência Fibonacci");
    else
        Console.WriteLine("O número informado não pertence a sequência Fibonacci");

    Console.ReadLine();
}