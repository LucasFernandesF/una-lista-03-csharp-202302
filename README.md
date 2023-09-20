# una-lista-03-csharp-202302

## Lucas Fernandes Firmino 622122322  

### 1. Escreva um algoritmo que leia 3 números a partir do teclado. O algoritmo deve apresentar:
a. O maior número.
b. O menor número.
c. A média aritmética dos três números.
```
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
```

### 2. Escreva o algoritmo de uma máquina de venda automática de salgadinhos, doces,sucos e refrigerantes. O algoritmo deve calcular o menor número de notas que deveser dado de troco para um pagamento efetuado. O algoritmo deve ler o valor da compra e o valor pago. Se o valor pago for menor que o valor da compra, a máquina deve apresentar uma mensagem, informando que a quantia paga é insuficiente para realizar a compra. A máquina aceita apenas notas de R$ 50,00, R$ 20,00, R$ 10,00, R$ 5,00, R$ 2,00 e R$1,00.
```
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

```
### 3. Escreva um algoritmo que resolva uma equação de segundo grau, realizando a verificação de consistência dos valores dos coeficientes ("a", "b" e "c") e do discriminante (delta).
```
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
```
### 4. Escreva um algoritmo que leia dois valores: o primeiro servindo de indicador de operação e o segundo correspondendo ao raio de um círculo ou esfera. Caso o primeiro valor lido seja:
```  
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
```
### 5. Escrever um algoritmo que leia a partir do teclado dois números reais e um dos símbolos de operação: + , - , * , / ou ^ . O algoritmo deve retornar o resultado da operação. Caso o símbolo informado seja diferente dos símbolos preestabelecidos, o algoritmo deve apresentar uma mensagem de erro, informando que o símbolo da operação é inválido.
```
double num1, num2;
string operador;

Console.WriteLine("Digite um número: ");
num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite outro número: ");
num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite um operador (+ , - , * , / ou ^): ");
operador = Convert.ToString(Console.ReadLine());


if (operador == "+")
    Console.WriteLine("A soma dos número é {0}", num1 + num2);
else if (operador == "-")
    Console.WriteLine("A subtração dos número é {0}", num1 - num2);
else if (operador == "*")
    Console.WriteLine("A multiplicação dos número é {0}", num1 * num2);
else if (operador == "/")
    Console.WriteLine("A divisão dos número é {0}", num1 / num2);
else if (operador == "^")
    Console.WriteLine("O exponencial dos número é {0}", Math.Pow(num1,num2));
else
    Console.WriteLine("O símbolo da operação é inválido.");

Console.ReadLine();
```

### 6. Crie um algoritmo que leia dois números inteiros e realize o sorteio de um número aleatório. O algoritmo deve validar qual é o menor e o maior número informado pelo teclado, para que independente da ordem que o usuário digite os números, consiga realizar o sorteio. Se o algoritmo gerar um número par, escreva na tela o número gerado e informe que ele é par. Se o algoritmo gerar um número ímpar, escreva na tela o número gerado e que ele é um número ímpar.

```
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
```
