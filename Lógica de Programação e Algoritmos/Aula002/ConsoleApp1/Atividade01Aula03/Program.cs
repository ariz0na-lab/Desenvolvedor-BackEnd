//Declaração de variáveis
int pergunta1;
int pergunta2;
int pergunta3;

//Entrada de dados
Console.WriteLine("1. Insira o valor A");
pergunta1 = int.Parse(Console.ReadLine());
Console.WriteLine("\n2. Insira o valor B");
pergunta2 = int.Parse(Console.ReadLine());
Console.WriteLine("\n3. Insira o valor C");
pergunta3 = int.Parse(Console.ReadLine());


//Saída de dados
Console.WriteLine($"\n1. O primeiro valor é igual ao terceiro valor? R:{(pergunta1 == pergunta3 ? "Sim" : "Não")}");
Console.WriteLine($"\n2. O segundo valor é diferente do segundo valor? R:{(pergunta1 != pergunta2 ? "Sim" : "Não")}");
Console.WriteLine($"\n3. O segundo valor é maior que o primeiro valor? R:{(pergunta2 > pergunta1 ? "Sim" : "Não")}");
Console.WriteLine($"\n4. O segundo valor é menor ou igual que o terceiro valor? R:{(pergunta2 <= pergunta3 ? "Sim" : "Não")}");


//Não exibir a tela de saída do console automaticamente
Console.ReadKey();