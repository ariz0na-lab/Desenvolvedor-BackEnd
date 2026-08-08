//Declaração de variveis
using System.Net;
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



while (true)
{
    try
    {
    Console.WriteLine
        ("""

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
    Console.Write("Digite o código do produto (ou 0 para sair): ");
        codigo = int.Parse(Console.ReadLine());

    if (codigo == 0)
    {
        Console.WriteLine("[FINALLY]: Operação concluída.");
        return;
    }
    else if (codigo == 1)
    {
        Console.Write("Digite a quantidade desejada: ");
        quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("\nProcessando pedido... (aguarde)");

        preco = quantidade * produtos[codigo];
        Console.WriteLine("\nItem selecionado: Cachorro Quente");
        Console.WriteLine($"Valor a pagar: {preco:c}");
        Console.WriteLine("----------------------------------------");
        if (true)
        {
            Console.Write("Deseja continuar S/N: ");
        }
    }
    else if (codigo == 2)
    {
        Console.Write("Digite a quantidade desejada: ");
        quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("\nProcessando pedido... (aguarde)");

        preco = quantidade * produtos[codigo];
        Console.WriteLine("\nItem selecionado: X-Salada");
        Console.WriteLine($"Valor a pagar: {preco:c}");
        Console.WriteLine("----------------------------------------");
    }
    else if (codigo == 3)
    {
        Console.Write("Digite a quantidade desejada: ");
        quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("\nProcessando pedido... (aguarde)");

        preco = quantidade * produtos[codigo];
        Console.WriteLine("\nItem selecionado: X-Bacon");
        Console.WriteLine($"Valor a pagar: {preco:c}");
        Console.WriteLine("----------------------------------------");
    }
    else if (codigo == 4)
    {
        Console.Write("Digite a quantidade desejada: ");
        quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("\nProcessando pedido... (aguarde)");

        preco = quantidade * produtos[codigo];
        Console.WriteLine("\nItem selecionado: Torrada Simples");
        Console.WriteLine($"Valor a pagar: {preco:c}");
        Console.WriteLine("----------------------------------------");
    }
    else if (codigo == 5)
    {
        Console.Write("Digite a quantidade desejada: ");
        quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("\nProcessando pedido... (aguarde)");

        preco = quantidade * produtos[codigo];
        Console.WriteLine("\nItem selecionado: Refrigerante");
        Console.WriteLine($"Valor a pagar: {preco:c}");
        Console.WriteLine("----------------------------------------");
    }
    
    else
    {
        Console.WriteLine("[ERRO]: Código de produto inválido! Tente novamente.");
    }
    }
    catch (Exception)
    {
        
        Console.WriteLine("[ERRO]: Código de produto inválido! Tente novamente.");
        continue;
    }
    
}

/*

while (true)
{
    
    Console.WriteLine
    ("""

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
    Console.Write("Digite o código do produto (ou 0 para sair): ");
    codigo = int.Parse(Console.ReadLine());

    if (codigo == 0)
    {
        Console.WriteLine("[FINALLY]: Operação concluída.");
        return;
    }
    else if (codigo == 1)
    {
        Console.Write("Digite a quantidade desejada: ");
        quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("\nProcessando pedido... (aguarde)");

        preco = quantidade * produtos[codigo];
        Console.WriteLine("\nItem selecionado: Cachorro Quente");
        Console.WriteLine($"Valor a pagar: {preco:c}");
        Console.Write("----------------------------------------");
        break;
    }
    else if (codigo == 2)
    {
        Console.Write("Digite a quantidade desejada: ");
        quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("\nProcessando pedido... (aguarde)");

        preco = quantidade * produtos[codigo];
        Console.WriteLine("\nItem selecionado: X-Salada");
        Console.WriteLine($"Valor a pagar: {preco:c}");
        Console.Write("----------------------------------------");
        break;
    }
    else if (codigo == 3)
    {
        Console.Write("Digite a quantidade desejada: ");
        quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("\nProcessando pedido... (aguarde)");

        preco = quantidade * produtos[codigo];
        Console.WriteLine("\nItem selecionado: X-Bacon");
        Console.WriteLine($"Valor a pagar: {preco:c}");
        Console.Write("----------------------------------------");
        break;
    }
    else if (codigo == 4)
    {
        Console.Write("Digite a quantidade desejada: ");
        quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("\nProcessando pedido... (aguarde)");

        preco = quantidade * produtos[codigo];
        Console.WriteLine("\nItem selecionado: Torrada Simples");
        Console.WriteLine($"Valor a pagar: {preco:c}");
        Console.Write("----------------------------------------");
        break;
    }
    else if (codigo == 5)
    {
        Console.Write("Digite a quantidade desejada: ");
        quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("\nProcessando pedido... (aguarde)");

        preco = quantidade * produtos[codigo];
        Console.WriteLine("\nItem selecionado: Refrigerante");
        Console.WriteLine($"Valor a pagar: {preco:c}");
        Console.Write("----------------------------------------");
        break;
    }
}


*/
