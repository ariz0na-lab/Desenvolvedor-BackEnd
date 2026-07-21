//Declaração de variáveis
double base1;
double altura;
double area;
double perimetro;
double diagonal;

//Entrada de dados
Console.Write("Digite a base do retângulo (em metros): ");
base1 = double.Parse(Console.ReadLine());
Console.Write("Digite a altura do retângulo (em metros): ");
altura = double.Parse(Console.ReadLine());

//Processamento de dados
area = base1 * altura;
perimetro = base1 + altura + base1 + altura;
diagonal = Math.Sqrt(Math.Pow(base1, 2) + Math.Pow(altura, 2));

//Saida de dados
Console.WriteLine($"\n\nA área do retângulo é: {area:f2} metros quadrados. " +
    $"\nPerímetro do retângulo: {perimetro:f4} metros. " +
    $"\nDiagonal do retângulo: {diagonal:.n} metros.");

