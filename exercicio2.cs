double valorPago, valorCompra, troco;
int nota50, nota20, nota10, nota5, nota2, nota1;

Console.WriteLine("Digite o valor da compra?");
valorCompra = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da nota do pagamento?");
valorPago = double.Parse(Console.ReadLine());
troco = valorPago - valorCompra;


if (valorPago > valorCompra)
{
    Console.WriteLine("Valor pago: " + valorPago);
    Console.WriteLine("Valor da compra: " + valorCompra);
    Console.WriteLine("Troco: " + troco);

}

nota50 = Convert.ToInt32(troco) / 50;
troco %= 50;
nota20 = Convert.ToInt32(troco) / 20;
troco %= 20;
nota10 = Convert.ToInt32(troco) / 10;
troco %= 10;
nota5 = Convert.ToInt32(troco) / 5;
troco %= 5;
nota2 = Convert.ToInt32(troco) / 2;
troco %= 2;
nota1 = Convert.ToInt32(troco);


Console.WriteLine("\nNotas de R$ 50,00: " + nota50);
Console.WriteLine("Notas de R$ 20,00: " + nota20);
Console.WriteLine("Notas de R$ 10,00: " + nota10);
Console.WriteLine("Notas de R$ 5,00: " + nota5);
Console.WriteLine("Notas de R$ 2,00: " + nota2);
Console.WriteLine("Notas de R$ 1,00: " + nota1);

Console.ReadLine();
