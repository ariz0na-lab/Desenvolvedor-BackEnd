//Declaração de variáveis
int numero1;
int numero2;
int numero3;
bool logica1;
bool logica2;
bool logica3;
bool pergunta1;
bool pergunta2;
bool pergunta3;
bool pergunta4;

//Entrada de dados
Console.WriteLine("1. Insira o valor A");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("\n2. Insira o valor B");
numero2 = int.Parse(Console.ReadLine());
Console.WriteLine("\n3. Insira o valor C");
numero3 = int.Parse(Console.ReadLine());


//Saída de dados
Console.WriteLine("- - Comprações - -");
Console.WriteLine($"1. O primeiro valor é igual ao terceiro valor? R:{(numero1 == numero2 ? "Sim" : "Não")}");
Console.WriteLine($"\n2. O segundo valor é diferente do segundo valor? R:{(numero3 != numero2 ? "Sim" : "Não")}");
Console.WriteLine($"\n3. O segundo valor é maior que o primeiro valor? R:{(numero2 > numero1 ? "Sim" : "Não")}");
Console.WriteLine($"\n4. O segundo valor é menor ou igual que o terceiro valor? R:{(numero2 <= numero3 ? "Sim" : "Não")}");

pergunta1 = numero1 == numero3;
pergunta2 = numero1 != numero2;
pergunta3 = numero2 > numero1;
pergunta4 = numero2 <= numero3;

logica1 = pergunta1 & pergunta3;
logica2 = pergunta2 | pergunta4;
logica3 = !pergunta1;

Console.WriteLine("- - Lógicas - -");
Console.WriteLine($"1. A pergunta 1 & 3 são verdadeiras? R:{(logica1 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"2. A pergunta 2 & 4, uma delas é verdadeira? R:{(logica2 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"3. A negação da primeira pergunta é verdadeira? R:{(logica3 ? "Verdadeiro" : "Falso")}");

//Não exibir a tela de saída do console automaticamente
Console.ReadKey();