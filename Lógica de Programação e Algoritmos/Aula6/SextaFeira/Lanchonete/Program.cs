// Sistema de lanchonete simples em C#

// Declaração de variaveis
int codigo, quantidade;
double preco;

// Entrada de dados
Console.Write("Digite o código do produto: ");
codigo = int.Parse(Console.ReadLine());
Console.Write("Digite a quantidade: ");
quantidade = int.Parse(Console.ReadLine());

// Estrutura de controle de seleção - swith case
switch (codigo)
{
    case 1:
        preco = 5.00;
        Console.WriteLine($"\nValor a pagar: {quantidade * preco:C}");
        Console.ReadKey();
        break;
    case 2:
        preco = 3.50;
        Console.WriteLine($"\nValor a pagar: {quantidade * preco:C}");
        Console.ReadKey();
        break;
    case 3:
        preco = 4.80;
        Console.WriteLine($"\nValor a pagar: {quantidade * preco:C}");
        Console.ReadKey();
        break;
    case 4:
        preco = 8.90;
        Console.WriteLine($"\nValor a pagar: {quantidade * preco:C}");
        Console.ReadKey();
        break;
    case 5:
        preco = 7.32;
        Console.WriteLine($"\nValor a pagar: {quantidade * preco:C}");
        Console.ReadKey();
        break;
    default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR! Código inválido, tente novamente.");
        Console.ForegroundColor= ConsoleColor.White;
        return; // Sai do programa se o código for inválido
}