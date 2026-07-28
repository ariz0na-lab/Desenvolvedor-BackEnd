//Atividade 02 - Verificar se os dados foram ou não um triângulo. Em caso positivo, calcule o perímetro do triângulo. Em caso negativo, informe que os dados não formam um triângulo. Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem

const string JANELA = "ATIVIDADE 02";
Console.Title = JANELA;

double a, b, c, perimetro, areaTrapezio;

try
{
    Console.Write("Digite o valor de A: ");
    a = double.Parse(Console.ReadLine());
    Console.Write("Digite o valor de B: ");
    b = double.Parse(Console.ReadLine());
    Console.Write("Digite o valor de C: ");
    c = double.Parse(Console.ReadLine());

    if (a + b > c && a + c > b && b + c > a)
    {
        await Task.Delay(1000);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nOs valores formam um triângulo.");
        Console.ForegroundColor = ConsoleColor.White;
        perimetro = a + b + c;
        Console.WriteLine($"Perímetro: {perimetro:f1}");
        Console.ReadKey();
    }
    else
    {
        await Task.Delay(1000);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nOs valores não formam um triângulo.");
        Console.ForegroundColor = ConsoleColor.White;
        areaTrapezio = ((a + b) * c) / 2;
        Console.WriteLine($"Área do trapézio: {areaTrapezio:f1}");
        Console.ReadKey();
    }
}
catch (FormatException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
    Console.ForegroundColor = ConsoleColor.White;
    Console.ReadKey();
}

double Perimetro()
{
    perimetro = a + b;
    return perimetro;
}