int n, x, y;

Console.Title = "Aula 07 - Divisão";

try
{
    //eNTRADA DE DADOS
    Console.WriteLine("Quantos casos você deseja processar?");
    n = int.Parse(Console.ReadLine()!);

    for (int i = 0; i < n; i++)
    {
        Console.Write("\nDigite o numerador: ");
        x = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o denominador: ");
        y = int.Parse(Console.ReadLine()!);

        if (y != 0)
        {
            Console.WriteLine($"Divisão = {((double)x / y):f2}");
        }
        else
        {   
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Denominador inválido!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
catch (Exception erro)
{

    Console.WriteLine($"Ocorreu um erro: {erro.Message}");
}
Console.ReadKey();