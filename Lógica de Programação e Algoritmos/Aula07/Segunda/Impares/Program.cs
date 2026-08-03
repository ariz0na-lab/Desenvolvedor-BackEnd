using static System.Linq.Enumerable;
using static System.Console;

Title = "Aula 07";

int x, y, controle, control;
int impar = 0;

try
{
    WriteLine("Digite dois números:");
    x = int.Parse(ReadLine()!);
    y = int.Parse(ReadLine()!);

    if (x < y)
    {
        controle = x;
        control = y;
    }
    else
    {
        controle = y;
        control = x;
    }

    foreach (int a in Range(controle, control - controle + 1))
    {
        if (a % 2 != 0 && a != x && a != y)
        {
            impar += a;
        }
    }

    WriteLine($"\nA soma dos ímpares é: {impar}");
}
catch (Exception erro)
{
    WriteLine($"Ocorreu um erro: {erro.Message}");
}

ReadKey();