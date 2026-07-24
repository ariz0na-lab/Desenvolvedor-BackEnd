// DateTime
// TimeSpan
/*
var horario = DateTime.Now;

DateTime data1 = new(1991, 8, 27);
DateTime data2 = new DateTime(1991, 8, 28);

var data = data1.AddDays(10);

Console.WriteLine(data.Month); 
*/


// Declaração de variáveis
Console.Title = "Conversor de Tempo";
int segundos, minutos, hora;

//Entrada de dados
Console.Write("Digite a quantidade de segundos: ");
int totalsegundos = int.Parse(Console.ReadLine());

//Processamento de dados

hora = totalsegundos / 3600;
minutos = (totalsegundos % 3600) / 60;
segundos = totalsegundos % 60;

//Saída de dados
Console.WriteLine($"{hora}:{minutos}:{segundos}");

Console.ReadKey();



