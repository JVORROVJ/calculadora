using System;

class Calculadora
{
    static void Main(string[] args)
    {
        double num1, num2;
        string operacao, cont;
        bool op = false;

        while (op == false)
        {

            Console.WriteLine("Bem-vindo à calculadora!");

            Console.WriteLine("Escolha a operação (+, -, *, /, r (raiz quadrada): ");
            operacao = Console.ReadLine();

            switch (operacao)
            {
                case "+":
                    Console.Write("Digite o primeiro número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Resultado: {num1} + {num2} = {Somar(num1, num2)}");
                    break;
                case "-":
                    Console.Write("Digite o primeiro número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Resultado: {num1} - {num2} = {Subtrair(num1, num2)}");
                    break;
                case "*":
                    Console.Write("Digite o primeiro número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Resultado: {num1} * {num2} = {Multiplicar(num1, num2)}");
                    break;
                case "/":
                    Console.Write("Digite o primeiro número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    if (num2 != 0)
                    {
                        Console.WriteLine($"Resultado: {num1} / {num2} = {Dividir(num1, num2)}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    break;
                case "r":
                    Console.Write("Digite o primeiro número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Resultado: {num1} = {Raiz(num1)}");
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }

            Console.WriteLine("Deseja continuar? (S/N)");
            cont = Console.ReadLine();
            if (cont == "s" || cont == "S")
                op = false;
            else
            {
                op = true;
            }
        }

        Console.WriteLine("Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }

    static double Somar(double a, double b)
    {
        return a + b;
    }

    static double Subtrair(double a, double b)
    {
        return a - b;
    }

    static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    static double Dividir(double a, double b)
    {
        return a / b;
    }

    static double Raiz(double a)
    {
        return Math.Sqrt(a);
    }
}