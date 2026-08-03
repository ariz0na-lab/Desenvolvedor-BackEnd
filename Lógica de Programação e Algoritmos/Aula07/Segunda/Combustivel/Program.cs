//Atividade de posto de combustivel

Console.Title = "Aula 07 - Posto de Combustível";

int codigo, alcool, gasolina, diesel;

codigo = 0;
alcool = 0;
gasolina = 0;
diesel = 0;

while (true)
{
    try
    {
        while (codigo != 4)
        {
            Console.Write("Digite o código do produto (1 - Álcool, 2 - Gasolina, 3 - Diesel | 4 - Fim): ");
            codigo = int.Parse(Console.ReadLine()!);
            if (codigo == 1)
            {
                alcool++;
            }
            else if (codigo == 2)
            {
                gasolina++;
            }
            else if (codigo == 3)
            {
                diesel++;
            }
            else if (codigo != 4)
            {
                Console.WriteLine("Código inválido! Digite novamente."); Console.WriteLine(codigo);
            }
        }
        Console.WriteLine("\nMuito obrigado!");
        Console.WriteLine("-------------------------");
        Console.WriteLine($"Álcool: {alcool}");
        Console.WriteLine($"Gasolina: {gasolina}");
        Console.WriteLine($"Diesel: {diesel}");
        Console.WriteLine("-------------------------");
        Console.ReadLine();
        break;
    }

    catch (Exception erro)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"Ocorreu um erro: {erro.Message}\n");
        Console.ForegroundColor = ConsoleColor.White;
    }
}