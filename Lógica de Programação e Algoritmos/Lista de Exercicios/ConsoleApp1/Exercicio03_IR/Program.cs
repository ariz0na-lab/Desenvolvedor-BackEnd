const string JANELA = "ATIVIDADE 03";
Console.Title = JANELA;

double valorHora, horasTrabalhadas, descontoIR;

try
{
    Console.Write("Informe o valor que você recebe por hora: R$ ");
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

    Console.WriteLine("\n======================================");
    Console.WriteLine($"Salário Bruto {valorHora * horasTrabalhadas:C}");
    Console.WriteLine($"(-) IR {descontoIR:C}");
    Console.WriteLine($"(-) INSS (10%): {descontoINSS:C}");
    Console.WriteLine($"FGTS (11%): {descontoFGTS:C}");
    Console.Write($"\nTotal de descontos ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{descontoIR + descontoINSS:C}");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write($"Salário Líquido: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{salarioBruto - descontoIR - descontoINSS:C}");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("======================================");
    Console.ReadKey();

}
catch (FormatException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
    Console.ForegroundColor = ConsoleColor.White;
    Console.ReadKey();
}

