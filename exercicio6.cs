int num1, num2, maiorNum, menorNum, numAleatorio;

Console.WriteLine("Digite um número inteiro: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite outro número inteiro: ");
num2 = Convert.ToInt32(Console.ReadLine());

maiorNum = Math.Max(num1, num2);
menorNum = Math.Min(num1, num2);

Random aleatorio = new Random();
numAleatorio = aleatorio.Next(menorNum, maiorNum + 1);

Console.WriteLine("Número gerado aleatoriamente: " + numAleatorio);

if (numAleatorio % 2 == 0)
{
    Console.WriteLine("O número gerado é PAR!");
}
else
{
    Console.WriteLine("O número gerado é ÍMPAR!");
}

Console.ReadLine();