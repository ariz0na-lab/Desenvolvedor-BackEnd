
const string JANELA = "ATIVIDADE 04";
Console.Title = JANELA;

int dia;

try
{
    Console.Write("Digite um dia da semana " +
        "\n(1-Domingo, 2-Segunda, 3-Terça, 4-Quarta, 5-Quinta, 6-Sexta, 7-Sábado)" +
        "\nR: ");
    dia = int.Parse(Console.ReadLine());


    if (dia == 1)
    {
        Console.WriteLine("\nDomingo");
        Console.ReadKey();
    }


    else if (dia == 2)
    {
        Console.WriteLine("\nSegunda");
        Console.ReadKey();
    }

    else if (dia == 3)
    {
        Console.WriteLine("\nTerça");
        Console.ReadKey();
    }
    else if (dia == 4)
    {
        Console.WriteLine("\nQuarta");
        Console.ReadKey();
    }
    else if (dia == 5)
    {
        Console.WriteLine("\nQuinta");
        Console.ReadKey();
    }
    else if (dia == 6)
    {
        Console.WriteLine("\nSexta");
        Console.ReadKey();
    }
    else if (dia == 7)
    {
        Console.WriteLine("\nSábado");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("\nValor inválido. Por favor, escolha um número correspondente ao dia da semana.");
        Console.ReadKey();
    }
}

catch (FormatException)
{
    Console.WriteLine("\nValor inválido. Por favor, escolha um número correspondente ao dia da semana.");
    Console.ReadKey();
}