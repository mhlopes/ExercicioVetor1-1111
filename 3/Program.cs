//3 - leia 1 int, usando esse numero, crie um vetor com essa quntia de posições, dentro desse vetor, precisa ter a seq fibonaci ate a sequencia X

Console.WriteLine("digite a quantidade de elementos para a sequência de Fibonacci:");
int quantidade = int.Parse(Console.ReadLine());

if (quantidade < 1)
{
    Console.WriteLine("Quantidade inválida, informe um valor maior que 0.");
    return;
}

long[] fibonacci = new long[quantidade];

void CalculoFibonacci(long[] vetor)
{
    vetor[0] = 0;

    if (vetor.Length > 1)
    {
        vetor[1] = 1;

        for (int i = 2; i < vetor.Length; i++)
        {
            vetor[i] = vetor[i - 1] + vetor[i - 2];
        }
    }
}

void ImprimirFibonacci(long[] vetor)
{
    Console.WriteLine("Sequencia Fibonacci:");
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.Write(vetor[i] + " ");
    }
    Console.WriteLine();
}

CalculoFibonacci(fibonacci);
ImprimirFibonacci(fibonacci);