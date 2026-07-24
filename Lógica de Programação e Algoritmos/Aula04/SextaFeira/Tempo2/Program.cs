using System;

//Declaração de variáveis
int totalsegundos, horas, minutos, segundos;

//Entrada de dados
Console.Write("Digite a duração em segundos: ");
totalsegundos = int.Parse(Console.ReadLine());

TimeSpan duracao = TimeSpan.FromSeconds(totalsegundos);

//Processamento de dados
horas = duracao.Hours;
minutos = duracao.Minutes;
segundos = duracao.Seconds;

//saída de dados
Console.WriteLine($"{horas}:{minutos}:{segundos}");
Console.ReadKey();

















//Csharp é