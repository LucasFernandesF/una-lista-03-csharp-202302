double num1, num2, num3, media;

Console.WriteLine("Digite o primeiro número:");
num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o primeiro número:");
num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o primeiro número:");
num3 = Convert.ToDouble(Console.ReadLine());

if (num1 > num2 && num1 > num3)
    Console.WriteLine("O maior número é " + num1);
else if (num2 > num1 && num2 > num3)
    Console.WriteLine("O maior número é " + num2);
else if (num3 > num1 && num3 > num2)
    Console.WriteLine("O maior número é " + num3);

if (num1 < num2 && num1 < num3)
    Console.WriteLine("O menor número é " + num1);
else if (num2 < num1 && num2 < num3)
    Console.WriteLine("O menor número é " + num2);
else if (num3 < num1 && num3 < num2)
    Console.WriteLine("O menor número é " + num3);
media = (num1 + num2 + num3) / 3;
Console.WriteLine("A média aritmética dos três números é " + media.ToString("F"));

Console.ReadLine();