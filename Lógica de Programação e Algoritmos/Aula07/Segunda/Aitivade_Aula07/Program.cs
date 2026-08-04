Console.Title = "Aula 07 - Parque de Estacionamento";

int veiculostatus, veiculoparque, turistaparque;

veiculostatus = 0;
veiculoparque = 0;
turistaparque = 0;


while (true)
{
	try
	{
		while (veiculostatus != 3)
		{
            Console.Write("\nVeículo está (1 - Entrando | 2 - Saindo ) ou (3 - Resumo): ");
			veiculostatus = int.Parse(Console.ReadLine()!);
            if (veiculostatus == 1)
            {
                Console.Write("Quantas pessoas estão no veículo?: ");
                int pessoasNoVeiculo = int.Parse(Console.ReadLine()!);
                if (pessoasNoVeiculo <=5)
                {
                    turistaparque += pessoasNoVeiculo;
                    veiculoparque++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número de pessoas excede o limite!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else if (veiculostatus == 2)
            {
                Console.Write("Quantas pessoas estão no veículo?: ");
                int pessoasNoVeiculo = int.Parse(Console.ReadLine()!);
                if (pessoasNoVeiculo <=5)
                {
                turistaparque -= pessoasNoVeiculo;
                veiculoparque--;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número de pessoas excede o limite!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else if (veiculostatus != 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Código inválido! Digite novamente.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        Console.Clear();
        Console.WriteLine("Resumo do expediente:");
        Console.WriteLine("-------------------------");
        Console.WriteLine($"Veiculos no parque: {veiculoparque}");
        Console.WriteLine($"Turistas no parque: {turistaparque}");
        Console.WriteLine("-------------------------");
        Console.ReadKey();
        break;
    }
	catch (Exception erro)
	{
		Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ocorreu um erro: " + erro.Message);
		Console.ForegroundColor = ConsoleColor.White;
    }
}