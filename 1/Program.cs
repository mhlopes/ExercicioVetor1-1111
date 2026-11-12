/*
1- leia até 6 caracteres, e grave em vetor, na ordem inserida, imprima vetor em ordem que foi inserida, depois em reverso

*/
char[] caracteres = new char[6];

Console.WriteLine("quantos caracteres irá salvar? (de 1 a 6)");
int quantidade = int.Parse(Console.ReadLine());

if (quantidade < 1 || quantidade > 6)
{
    Console.WriteLine("Quantidade inválida, informe um valor entre 1 e 6.");
    return;
}

string ValidarCaractereUnico(int posicao)
{
    while (true)
    {
        Console.WriteLine($"\nDigite o {posicao}º caractere:");
        string entrada = Console.ReadLine();

        if (string.IsNullOrEmpty(entrada))
        {
            Console.WriteLine("pelo menos 1 caractere deve ser inserido");
        }
        else if (entrada.Length > 1)
        {
            Console.WriteLine("pode apenas 1 unidade de caractere por vez");
        }
        else
        {
            return entrada;
        }
    }
}

for (int i = 0; i < quantidade; i++)
{
    string entrada = ValidarCaractereUnico(i + 1);
    caracteres[i] = entrada[0];
}

void ImprimirOrdemInserida(char[] vetor, int quantidade)
{
    Console.WriteLine("\nOrdem inserida:");
    for (int i = 0; i < quantidade; i++)
    {
        Console.Write(vetor[i] + " ");
    }
    Console.WriteLine();
}

void ImprimirOrdemReversa(char[] vetor, int quantidade)
{
    Console.WriteLine("Ordem reversa:");
    for (int i = quantidade - 1; i >= 0; i--)
    {
        Console.Write(vetor[i] + " ");
    }
    Console.WriteLine();
}

ImprimirOrdemInserida(caracteres, quantidade);
ImprimirOrdemReversa(caracteres, quantidade);