//Exercicio NOTAS
double nota1, nota2, notafinal;

try
{
    // Entrada de dados
    Console.WriteLine("Sistema de Notas.");
    await Task.Delay(1000);
    Console.WriteLine("Informe suas notas a seguir para cálculo da nota final.");
    await Task.Delay(1000);
    Console.Write("\nDigite a primeira nota: ");
    nota1 = double.Parse(Console.ReadLine());
    Console.Write("Digite a segunda nota: ");
    nota2 = double.Parse(Console.ReadLine());
    // Processamento de dados
    Nota();
    // Saída de dados
    if (notafinal >= 60) //Atribuição de = ou + de 60
    {
        Console.Write("NOTA FINAL: ");
        await Task.Delay(1000); // Adiciona um atraso de 1 segundo antes de exibir a nota final
        Console.Write($"{notafinal:f1}");
        Console.ForegroundColor = ConsoleColor.Green; // Altera a cor do texto para verde
        Console.Write("\nAPROVADO");
        Console.ForegroundColor = ConsoleColor.White;   
        Console.ReadKey(); // Aguarda o usuário pressionar uma tecla antes de encerrar o programa
    }
    /* else if (notafinal < 60) //Atribuição de menor que 60
    {
        Console.Write("NOTA FINAL: ");
        await Task.Delay(1000);
        Console.Write($"{notafinal:f1}");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\nREPROVADO");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadKey();
    }
    */
    else if (notafinal == 100)
    {
        Console.Write("NOTA FINAL: ");
        await Task.Delay(1000);
        Console.Write($"{notafinal:f1}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("\nAPROVADO COM 100% DE APROVEITAMENTO");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadKey();
    }
    else //Atribuição de menor que 60
    {
        Console.Write("NOTA FINAL: ");
        await Task.Delay(1000);
        Console.Write($"{notafinal:f1}");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\nREPROVADO");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadKey();
    }

}
catch (FormatException)
{
    Console.WriteLine("Erro: Entrada inválida. Por favor, digite um número válido.");
    Console.ReadKey();
}

double Nota()
{
    notafinal = nota1 + nota2;
    return notafinal;
}
