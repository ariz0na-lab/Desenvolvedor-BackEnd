/*
Problema "medidas"
Fazer um programa para ler três medidas A, B e C. Em seguida, calcular e mostrar (imprimir os dados
com quatro casas decimais):
a) a área do quadrado que tem lado A
b) a área do triângulo retângulo que base A e altura B
c) a área do trapézio que tem bases A e B, e altura C
*/


using static System.Console; //Não ficar chamando Console.WriteLine() toda hora

try
{
    // Declarações de variveis
    int a, b, c;
    double area_q, area_t, area_tp;

    // Entrada de dados
    Write("Digite o valor de A: ");
    a = int.Parse(ReadLine());
    Write("Digite o valor de B: ");
    b = int.Parse(ReadLine());
    Write("Digite o valor de C: ");
    c = int.Parse(ReadLine());

    // Processamento de dados
    area_q = Math.Pow(a, 2);
    area_t = (a * b) / 2;
    area_tp = ((a + b) * c) / 2;

    // Saida de dados
    WriteLine($"A área do quadrado é: {area_q:F4}");
    WriteLine($"A área do triângulo retângulo é: {area_t:F4}");
    WriteLine($"A área do trapézio é: {area_tp:F4}\n");

    WriteLine("Pressione qualquer tecla para sair...");
}
catch
{
    Console.BackgroundColor = ConsoleColor.Red;
    WriteLine("ERRO! Digite um valor válido!");
}
finally
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Red;
    WriteLine("\nEncerrando o programa.");
}
    Console.ReadKey();