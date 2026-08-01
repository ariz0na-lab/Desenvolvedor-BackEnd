Console.Title = "CATRACA | YOK PARK";

double alturaMinima = 1.60;
double alturaMaxima = 1.80;
int totalpermitidos = 0;

Console.Write("Quantos visitantes vão entrar no brinquedo? R:");
int visitantes = int.Parse(Console.ReadLine());

for (int i = 0; i < visitantes; i++)
{
    Console.Write($"\nDigite a altura do visitante {i + 1}: ");
    Console.ForegroundColor = ConsoleColor.Red;
    double altura = double.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.White;

    if (altura < alturaMinima)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Recusado.");
        Console.ForegroundColor = ConsoleColor.White;
        continue;
    }
    else if (altura > alturaMaxima)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Recusado.");
        Console.ForegroundColor = ConsoleColor.White;
        continue;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Liberado.");
        Console.ForegroundColor = ConsoleColor.White;
        totalpermitidos = totalpermitidos + 1;
        continue;
    }
}

Console.WriteLine($"\n-------------------------------------");
Console.Write($"Total de visitantes que entraram: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{totalpermitidos}");
Console.ForegroundColor= ConsoleColor.White;
Console.WriteLine($"-------------------------------------");

Console.ReadLine();