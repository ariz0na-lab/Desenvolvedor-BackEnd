
const string JANELA = "ATIVIDADE 01";
Console.Title = JANELA;

int turno;

try
{
    Console.Write("Qual turno você estuda? " +
        "\n(M/Matutino, V/Vespertino, N/Noturno)" +
        "\nR: ");
    turno = char.Parse(Console.ReadLine());


    if (turno == 'M' || turno == 'm')
    {
        Console.WriteLine("\nBom dia!");
        Console.ReadKey();
    }


    else if (turno == 'V' || turno == 'v')
    {
        Console.WriteLine("\nBoa tarde!");
        Console.ReadKey();
    }

    else if (turno == 'N' || turno == 'n')
    {
        Console.WriteLine("\nBoa noite!");
        Console.ReadKey();
    }

    else
    {
        Console.WriteLine("\nValor inválido. Por favor, escolha uma letra correspondente ao turno.");
        Console.ReadKey();
    }
}

catch (FormatException)
{
    Console.WriteLine("\nValor inválido. Por favor, escolha uma letra correspondente ao turno.");
    Console.ReadKey();
}