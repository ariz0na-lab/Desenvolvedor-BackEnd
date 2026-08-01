//
int x, y;

do
{
    Console.WriteLine("\nDigite dois números: ");
    Console.Write("- ");
    x = int.Parse(Console.ReadLine());
    Console.Write("- ");
    y = int.Parse(Console.ReadLine());
    if (x < y)
    {
        Console.WriteLine("Crescente");

    }
    else if (x > y)
    {
        Console.WriteLine("Decrescente");
    }
} while(x != y);


Console.ReadLine();