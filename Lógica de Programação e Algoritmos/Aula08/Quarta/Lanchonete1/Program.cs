//Declaração de variveis
using System.Net.Http.Headers;

Dictionary<int,double> produtos = new Dictionary<int, double>()
{
   //Código , Valor
    {  1    , 4.50 },
    {  2    , 4.50 },
    {  3    , 5.00 },
    {  4    , 2.00 },
    {  5    , 1.50 }
};
int codigo, quantidade;
double preco;

try
{
    //Entrada de dados
    Console.Write("========================================");
    Console.Write("           CARDÁPIO DA LANCHONETE       ");
    Console.Write("========================================");
    Console.Write("CÓDIGO | ITEM            | PREÇO        ");
    Console.Write("----------------------------------------");
    Console.Write("  1    | Cachorro Quente | R$ 4,50      ");
    Console.Write("  2    | X-Salada        | R$ 4,50      ");
    Console.Write("  3    | X-Bacon         | R$ 5,00      ");
    Console.Write("  4    | Torrada Simples | R$ 2,00      ");
    Console.Write("  5    | Refrigerante    | R$ 1,50      ");
    Console.Write("========================================");
    Console.Write("\nDigite o código do produto | ou 0 para sair |: ");
    codigo = int.Parse(Console.ReadLine());
    Console.Write("Digite a quantidade desejada: ");
    
    Console.Write("Processando pedido... (aguarde)");
    quantidade = int.Parse(Console.ReadLine());

    //Processamento de dados
    preco = quantidade * produtos[codigo];

    //Saida de dados
    Console.WriteLine($"Valor a pagar: {preco:c}");
}
catch (Exception e)
{
    Console.WriteLine("Valor inválido, erro: " + e); ;
}