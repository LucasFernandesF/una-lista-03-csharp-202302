double perimetroCirculo, areaCirculo, volumeEsfera, raio;
int opcao;

Console.WriteLine("Escolha uma das opções abaixo:\n1.Calcular e imprimir o perímetro do círculo.");
Console.WriteLine("2.Calcular e imprimir a área do círculo.\n3.Calcular e imprimir o volume da esfera.");
opcao = Convert.ToInt32(Console.ReadLine());

if (opcao == 1)
{
    Console.WriteLine("Calcular e imprimir o perímetro do círculo");
    Console.WriteLine("Digite o raio do círculo: ");
    raio = Convert.ToDouble(Console.ReadLine());
    perimetroCirculo = 2 * Math.PI * raio;
    Console.WriteLine("O perímetro do círculo é " + perimetroCirculo.ToString("F"));
}
else if (opcao == 2)
{
    Console.WriteLine("Calcular e imprimir a área do círculo");
    Console.WriteLine("Digite o raio do círculo: ");
    raio = Convert.ToDouble(Console.ReadLine());
    areaCirculo = Math.PI * Math.Pow(raio, 2);
    Console.WriteLine("A área do círculo é " + areaCirculo.ToString("F"));
}
else if (opcao == 3)
{
    Console.WriteLine("Calcular e imprimir o volume da esfera.");
    Console.WriteLine("Digite o raio da esfera: ");
    raio = Convert.ToDouble(Console.ReadLine());
    volumeEsfera = 4 * Math.PI * Math.Pow(raio, 3) / 3;
    Console.WriteLine("O volume da esfera é " + volumeEsfera.ToString("F"));
}
else
{
    Console.WriteLine("O código da operação é inválido!!");
}
Console.ReadLine();