Console.Title = "CATRACA | YOK PARK";

double alturaMinima = 1.60;
double alturaMaxima = 1.80;
int totalpermitidos = 0;

Console.Write("Portão abrindo .");
    await Task.Delay(500);
    Console.Write(" .");
    await Task.Delay(500);
    Console.Write(" .");
    await Task.Delay(500);
    Console.Write(" .");
    await Task.Delay(500);
    Console.Write(" .");
    await Task.Delay(500);
    Console.Write(" .");
    await Task.Delay(500);
    Console.Write(" .");
    await Task.Delay(500);
    Console.WriteLine(" .");
Console.WriteLine("Portão aberto!");
await Task.Delay(500);

Console.Write("Quantos visitantes estão na fila? R:");
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