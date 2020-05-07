using System;
using System.Globalization;
namespace Capitulo5_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular da Conta: ");
            string titular = Console.ReadLine();
            Console.Write("Deposito inicial (s/n) ");
            char opcao = char.Parse(Console.ReadLine());
            if(opcao == 's' || opcao == 'S')
            {
                Console.Write("Qual o valor do deposito: ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Valor do deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Valor do saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(conta);





        }
    }
}
