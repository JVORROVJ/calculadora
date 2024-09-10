using System;

class Calculadora
{
    static void Main(string[] args)
    {
        double num1, num2;
        string operacao;

        Console.WriteLine("Bem-vindo à calculadora!");
        Console.Write("Digite o primeiro número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escolha a operação (+, -, *, /): ");
        operacao = Console.ReadLine();

        Console.Write("Digite o segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (operacao)
        {
            case "+":
                Console.WriteLine($"Resultado: {num1} + {num2} = {Somar(num1, num2)}");
                break;
            case "-":
                Console.WriteLine($"Resultado: {num1} - {num2} = {Subtrair(num1, num2)}");
                break;
            case "*":
                Console.WriteLine($"Resultado: {num1} * {num2} = {Multiplicar(num1, num2)}");
                break;
            case "/":
                if (num2 != 0)
                {
                    Console.WriteLine($"Resultado: {num1} / {num2} = {Dividir(num1, num2)}");
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
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
}
