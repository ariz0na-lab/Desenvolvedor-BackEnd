double alturaMinima = 1.60;
double alturaMaxima = 1.80;
int totalpermitidos = 0;

Console.WriteLine("Quantos visitantes vão entrar no brinquedo?");
int visitantes = int.Parse(Console.ReadLine());

for (int i = 0; i < visitantes; i++)
{
    Console.Write($"\nDigite a altura do visitante {i + 1}: ");
    Console.ForegroundColor = ConsoleColor.Red;
    double altura = double.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.White;

    if (altura < alturaMinima)
    {
        Console.WriteLine("Visitante não pode entrar no brinquedo, altura abaixo do permitido.");
        continue;
    }
    else if (altura > alturaMaxima)
    {
        Console.WriteLine("Visitante não pode entrar no brinquedo, altura acima do permitido.");
        continue;
    }
    else
    {
        Console.WriteLine($"Visitante pode entrar no brinquedo.");
        totalpermitidos = totalpermitidos + 1;
        continue;
    }
}

Console.WriteLine($"\nTotal de visitantes que entraram: {totalpermitidos}");

Console.ReadLine();