// Sistema de lanchonete simples em C#

// Declaração de variaveis
int codigo, quantidade;
double preco;

// Entrada de dados
Console.Write("""
========================================
           CARDÁPIO DA LANCHONETE       
========================================
CÓDIGO | ITEM            | PREÇO       
----------------------------------------
  1    | Cachorro Quente | R$ 4,50     
  2    | X-Salada        | R$ 4,50     
  3    | X-Bacon         | R$ 5,00     
  4    | Torrada Simples | R$ 2,00     
  5    | Refrigerante    | R$ 1,50     
========================================
""");
Console.Write("Digite o código do produto | Ou 0 para sair |: ");
codigo = int.Parse(Console.ReadLine());
Console.Write("Digite a quantidade: ");
quantidade = int.Parse(Console.ReadLine());



// Estrutura de controle de seleção - swith case
switch (codigo)
{
    case 0:
        Console.WriteLine("\n[FINALLY]: Operação concluída.");
        break;
    case 1:
        preco = 4.50;
        Console.WriteLine("\nItem selecionado: Cachorro Quente");
        Console.WriteLine($"Valor a pagar: {quantidade * preco:C}");
        Console.ReadKey();
        break;
    case 2:
        preco = 4.50;
        Console.WriteLine("\nItem selecionado: Cachorro Quente");
        Console.WriteLine($"Valor a pagar: {quantidade * preco:C}");
        Console.ReadKey();
        break;
    case 3:
        preco = 5.00;
        Console.WriteLine("\nItem selecionado: Cachorro Quente");
        Console.WriteLine($"Valor a pagar: {quantidade * preco:C}");
        Console.ReadKey();
        break;
    case 4:
        preco = 2.00;
        Console.WriteLine("\nItem selecionado: Cachorro Quente");
        Console.WriteLine($"Valor a pagar: {quantidade * preco:C}");
        Console.ReadKey();
        break;
    case 5:
        preco = 1.50;
        Console.WriteLine("\nItem selecionado: Cachorro Quente");
        Console.WriteLine($"Valor a pagar: {quantidade * preco:C}");
        Console.ReadKey();
        break;
    default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR! Código inválido, tente novamente.");
        Console.ForegroundColor= ConsoleColor.White;
        return; // Sai do programa se o código for inválido
}