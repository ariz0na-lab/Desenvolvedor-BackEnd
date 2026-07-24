//Exercício Idades
//Declaração de variáveis
using System;

var nome1 = "SENAI";
var nome2 = "SENAI";
var idade1 = 1;
var idade2 = 2;
var media = 1.73;

//Entrada de dados
Console.WriteLine("Digite os dados do primeiro aluno:");
Console.Write("Nome:");
nome1 = Console.ReadLine();

Console.Write("Idade:");
idade1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite os dados do segundo aluno:");
Console.Write("Nome:");
nome2 = Console.ReadLine();

Console.Write("Idade:");
idade2 = int.Parse(Console.ReadLine());

//Processamento de dados
media = (idade1 + idade2) / 2.0;

//Saída de dados
Console.WriteLine($"A idade média de {nome1} e {nome2} é: {media:f2}");