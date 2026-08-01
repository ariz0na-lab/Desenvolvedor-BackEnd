//Quantos impares possui dentro de um valor X

int x;

Console.Write("Digite o valor de X: ");
x = int.Parse(Console.ReadLine());



for (int i = 0; i < x; i++)
{
     if (i%2 !=0)
    { 
        Console.WriteLine(i);
    }
}

foreach (int item in x)
{

}


Console.ReadKey();
