//4- crie 1 vetor de string [10], copie para um novo vetor cada uma das posições, adicionando n próxima, o valor da tabela ascii daquele caractere

string[] palavras = new string[10];
for (int i = 0; i < palavras.Length; i++)
{
    Console.Write($"Digite a {i + 1}ª palavra: ");
    palavras[i] = Console.ReadLine();
    palavras[i] = ValidarCharUnico(palavras[i]);
}

string ValidarCharUnico(string palavra)
{
    while(true)
    {
        if (string.IsNullOrEmpty(palavra))
        {
            Console.WriteLine("A palavra não pode ser vazia.");
            Console.Write($"Digite a palavra novamente: ");
            palavra = Console.ReadLine();
        }
        else if (palavra.Length > 1)
        {
            Console.WriteLine("A palavra deve conter apenas um caractere.");
            Console.Write($"Digite a palavra novamente: ");
            palavra = Console.ReadLine();
        }
        else
        {
            return palavra;
        }
    }
}

string[] palavrasComAscii = new string[10];
for (int i = 0; i < palavras.Length; i++)
{
    string palavra = palavras[i]; 
    string palavraComAscii = "";
    foreach (char caractere in palavra)
    {
        int valorAscii = (int)caractere;
        palavraComAscii += caractere + " - " + valorAscii.ToString();
    }
    palavrasComAscii[i] = palavraComAscii;
}
void ExibirVetores(string[] vetor, string nomeVetor)
{
    Console.WriteLine($"\n{nomeVetor}:");
    foreach (string item in vetor)
    {
        Console.WriteLine(item);
    }
}

ExibirVetores(palavras, "Vetor Original");
ExibirVetores(palavrasComAscii, "Vetor com ASCII");
