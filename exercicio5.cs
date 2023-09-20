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
