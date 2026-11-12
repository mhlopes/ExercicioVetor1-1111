// 2- leia 5 int, e grave em 1 vetor, vetor deve ser copiado para novo em sequencia inversa, faça o mesmo copiando para outros 2 vetores, 1 par e outro impar

int[] numeros = new int[5];
Console.WriteLine("digite 5 números inteiros");

for (int i = 0; i < 5; i++)
{
    Console.Write($"digite o {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

int[] vetorInverso = new int[5];
for (int i = 0; i < 5; i++)
{
    vetorInverso[i] = numeros[4 - i];
}

int[] vetorPar = new int[5];
int[] vetorImpar = new int[5];

int contadorPar = 0;
int contadorImpar = 0;

void ValidarParImpar(int numero)
{
    for (int i = 0; i < 5; i++)
    {
        if (numeros[i] % 2 == 0)
        {
            vetorPar[contadorPar] = numeros[i];
            contadorPar++;
        }
        else
        {
            vetorImpar[contadorImpar] = numeros[i];
            contadorImpar++;
        }
    }
}

ValidarParImpar(numeros[0]);

void ExibirVetores(int[] vetor, int tamanho, string nomeVetor)
{
    Console.WriteLine($"\n{nomeVetor}:");
    for (int i = 0; i < tamanho; i++)
    {
        Console.Write(vetor[i] + " ");
    }
    Console.WriteLine();
}

ExibirVetores(numeros, 5, "Vetor Original");
ExibirVetores(vetorInverso, 5, "Vetor Inverso");
ExibirVetores(vetorPar, contadorPar, "Vetor Par");
ExibirVetores(vetorImpar, contadorImpar, "Vetor Impar");