//Declaração de variáveis
double largura;
double comprimento;
double area;
double valor;
double preco;

//Entrada de dados
Console.Write("Digite a largura do terreno (em metros): ");
largura = double.Parse(Console.ReadLine());
Console.Write("Digite o comprimento do terreno (em metros): ");
comprimento = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do metro quadrado do terreno (em reais): ");
valor = double.Parse(Console.ReadLine());

//Processamento de dados
area = largura * comprimento;
preco = area * valor;

//Saida de dados
Console.WriteLine($"\n\nA área do terreno é: {area:n} metros quadrados. \nPreço do terro: R$ {preco:n}");
Console.WriteLine ("\n\nPressione qualquer tecla para sair...");

Console.ReadLine(); //Evitar fechamento automático do console