
const string JANELA = "ATIVIDADE 02";
Console.Title = JANELA;

double salario, reajuste, novoSalario;

try
{
    Console.Write("Informe seu salário: ");
    salario = double.Parse(Console.ReadLine());

    if (salario <= 280)
    {
        reajuste = salario * 0.20;
    }
    else if (salario <= 700)
    {
        reajuste = salario * 0.15;
    }
    else if (salario <= 1500)
    {
        reajuste = salario * 0.10;
    }
    else
    {
        reajuste = salario * 0.05;
    }

    novoSalario = salario + reajuste;

    Console.WriteLine($"\nSalário antes do reajuste: {salario:c}");
    Console.WriteLine($"Percentual de aumento aplicado: {((reajuste / salario) * 100):f2}%");
    Console.WriteLine($"Valor do aumento: {reajuste:c}");
    Console.WriteLine($"Novo salário: {novoSalario:c}");
    Console.ReadKey();
}
catch (FormatException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
    Console.ForegroundColor = ConsoleColor.White;
    Console.ReadKey();
}






