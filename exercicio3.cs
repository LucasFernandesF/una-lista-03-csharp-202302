double a, b, c, equacaoPrimeiroGrau, delta, x1, x2;

Console.WriteLine("Digite o coeficiente a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o coeficiente b: ");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o coeficiente c: ");
c = Convert.ToDouble(Console.ReadLine());
delta = Math.Pow(b, 2) - 4 * a * c;
x1 = (-b + Math.Sqrt(delta)) / 2 * a;
x2 = (-b - Math.Sqrt(delta)) / 2 * a;

if (a == 0 && b == 0 && c != 0)
    Console.WriteLine("Coeficientes informados incorretamente");
else if (a == 0 && b != 0)
{
    equacaoPrimeiroGrau = -c / b;
    Console.WriteLine("Essa é uma equação de primeiro grau, o valor da raiz da equação é " + equacaoPrimeiroGrau);
}
else if (delta < 0)
    Console.WriteLine("Esta equação não possui raízes reais");
else if (delta == 0)
{
    Console.WriteLine("Esta equação possui duas raízes reais iguais.");
    Console.WriteLine("As raízes são: ");
    Console.WriteLine("x1 = " + x1);
    Console.WriteLine("x2 = " + x2);
}
else if (delta > 0)
{
    Console.WriteLine("Esta equação possui duas raízes reais diferentes.");
    Console.WriteLine("As raízes são: ");
    Console.WriteLine("x1 = " + x1);
    Console.WriteLine("x2 = " + x2);
}

Console.ReadLine();