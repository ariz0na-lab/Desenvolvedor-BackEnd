const string JANELA = "ATIVIDADE 05";
Console.Title = JANELA;

double ladoA, ladoB, ladoC;

try
{
    
    Console.WriteLine("Digite os três lados do triângulo:");
    Console.Write("Lado A: ");
    ladoA = double.Parse(Console.ReadLine());
    Console.Write("Lado B: ");
    ladoB = double.Parse(Console.ReadLine());
    Console.Write("Lado C: ");
    ladoC = double.Parse(Console.ReadLine());

    
    if (ladoA == ladoB && ladoA == ladoC)
    {
        Console.WriteLine("\nÉ um Equilátero.");
        Console.ReadKey();
    }
    else if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
    {
        Console.WriteLine("\nÉ um triângulo");
        Console.ReadKey();
    }

    else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
    {
        Console.WriteLine("\nÉ um Isósceles.");
        Console.ReadKey();
    }

    else if (ladoA != ladoB && ladoA != ladoC && ladoB != ladoC)
    {
        Console.WriteLine("\nÉ um Escaleno.");
        Console.ReadKey();
    }

    else
    {
        Console.WriteLine("\nErro 404");
        Console.ReadKey();
    }

}
catch (FormatException)
{
    Console.WriteLine("Valor inválido. Por favor, digite um número válido.");
    Console.ReadKey();
    return;
}

