using System;
using System.Globalization;

namespace projeto5
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria Conta;

            Console.Write("Entre o numéro da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inical (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor do depósito inical: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                Conta = new ContaBancaria(numero, titular, depositoInicial);
            }

            else
            {
                Conta = new ContaBancaria(numero, titular);

            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(Conta);


            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(Conta);


            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // reutilizei a mesma variavel utilizada e criada acima
            Conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(Conta);



        }
    }
}
