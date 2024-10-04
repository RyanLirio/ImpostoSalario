using System;
using System.Globalization;

namespace calculoSalario
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Funcionario f = new Funcionario();
            Console.WriteLine("Qual seu nome?");
            f.Nome = Console.ReadLine();

            do
            {
                Console.WriteLine("Qual seu salario bruto?");
                f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Qual o imposto que você paga em cima do seu salário?");
                f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Dados: " + f);
                Console.Write("\nDigite a porcentagem que você vai receber de aumento:");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double aumento = f.SalarioBruto + ((porcentagem / 100) * f.SalarioBruto);
                f.SalarioBruto = aumento;
                Console.WriteLine("Dados atualizados: " + f);

                Console.WriteLine("Gostaria de realizar outra simulação? Aperte a tecla ENTER\n(Para finalizar aperte a tecla ESC)");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}