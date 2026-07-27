//Tarefa Restaurante | Garçon

const string JANELA = "Restaurante | Garçon";
Console.Title = JANELA;

// Chamando a função principal


async Task Principal()
{
    Console.WriteLine("Pedido anotado!");

    await Task.WhenAll(PrepararHamburguer(), PrepararBatata(), PrepararMilkShake());
    Console.WriteLine("\nPedido entregue!");
}
async Task PrepararHamburguer()
{
    Console.WriteLine("Preparando hambúrguer...");
    await Task.Delay(3000);
    Console.WriteLine("Hambúrguer pronto!");
}
async Task PrepararBatata()
{
    Console.WriteLine("Preparando batata...");
    await Task.Delay(3000);
    Console.WriteLine("Batata pronta!");
}
async Task PrepararMilkShake()
{
    Console.WriteLine($"Preparando milkshake...");
    await Task.Delay(3000);
    Console.WriteLine("Milkshake pronto!");
}

Principal();

Console.ReadKey();