const string JANELA = "ATIVIDADE 03";
Console.Title = JANELA;

double valorHora, horasTrabalhadas, descontoIR;

try
{
    Console.Write("Informe o valor que você recebe por hora: ");
    valorHora = double.Parse(Console.ReadLine());
    Console.Write("Digite quantas horas trabalhadas no mês: ");
    horasTrabalhadas = double.Parse(Console.ReadLine());

    double salarioBruto = valorHora * horasTrabalhadas;
    double descontoINSS = salarioBruto * 0.10;
    double descontoFGTS = salarioBruto * 0.11;

    if (salarioBruto <= 1500)
    {
        descontoIR = salarioBruto * 0.05;
    }
    else if (salarioBruto <= 2500)
    {
        descontoIR = salarioBruto * 0.10;
    }
    else if (salarioBruto >= 2500)
    {
        descontoIR = salarioBruto * 0.20;
    }

    else
    {
        descontoIR = 0;
    }

    Console.WriteLine($"\nSalário Bruto {valorHora * horasTrabalhadas:C}");
    Console.WriteLine($"Desconto IR {descontoIR:C}");
    Console.WriteLine($"(-) INSS (10%): {descontoINSS:C}");
    Console.WriteLine($"FGTS (11%): {descontoFGTS:C}");
    Console.WriteLine($"Total de descontos {descontoIR + descontoINSS :C}");
    Console.WriteLine($"Salário Líquido: {salarioBruto - descontoIR - descontoINSS:C}");
    Console.ReadKey();

}
catch (FormatException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
    Console.ForegroundColor = ConsoleColor.White;
    Console.ReadKey();
}

