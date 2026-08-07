//Exercico tabuada

// Entrada de dados
Console.Write("Qual número você deseja a tabuada? ");
int n = int.Parse(Console.ReadLine());

// Estrtura do FOR
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{n} x {i+1} = {n * (i+1)} ");
}

Console.ReadKey();