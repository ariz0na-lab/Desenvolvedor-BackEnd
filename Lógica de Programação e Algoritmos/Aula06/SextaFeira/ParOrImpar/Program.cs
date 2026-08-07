//Atividade par ou impar

Console.Write("Quantos número você vai digitar: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Write("\nDigite um número: ");
    int num = int.Parse(Console.ReadLine());

    if (num < 0)
    {
        Console.WriteLine("Negativo");
    }
    else if (num == 0)
    {
        Console.WriteLine("Null");
        continue;
    }
    else
    {
        Console.WriteLine("Positivo");
    }

    if (num %2 == 0)
    {
        Console.WriteLine("Par");
    }
    else
    {
        Console.WriteLine("Ímpar");
    }
}

Console.ReadLine();
