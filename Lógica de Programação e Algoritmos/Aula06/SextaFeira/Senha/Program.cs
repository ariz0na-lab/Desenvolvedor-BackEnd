// Senha única de acesso
Console.Title = "LOGIN";

const int senha = 2002;

Console.WriteLine("Usuario: Root");
Console.Write("Digite a senha: ");
int senhadigitada = int.Parse(Console.ReadLine());

while (senha != senhadigitada)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nSenha Invalida!");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Digite a senha: ");
    senhadigitada = int.Parse(Console.ReadLine());
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nAcesso Permitido!");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();