

//declaração de variáveis
double a, b, c, quadrado, triangulo, trapezio;

//entrada de dados
Console.Write("Digite a medida do lado A: ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a medida do lado B: ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a medida do lado C: ");
c = Convert.ToDouble(Console.ReadLine());

//processamento de dados
AreaQuadrado();
AreaTriangulo();
AreaTrapezio();

Saida();

Console.ReadKey();

double AreaQuadrado()
{
    quadrado = a * a;
    return quadrado;
}

double AreaTriangulo()
{
    triangulo = (a * b) / 2;
    return triangulo;
}

double AreaTrapezio()
{
    trapezio = ((a + b) * c) / 2;
    return trapezio;
}

//saída de dados
void Saida()
{
    Console.WriteLine($"\nÁrea do quadrado: {quadrado:f4}\n" +
        $"Área do triângulo: {triangulo:f4}\n" +
        $"Área do trapézio: {trapezio:f4}");
}


