using System;
using System.Collections.Generic;
using System.Globalization;

namespace projeto8
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>(); // esta puxando a clsse funcionário

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Empregado #" + i + ":");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, salario, nome)); // adicionando as informações coletadas acima a lista, com referencia na classe criada e adionando as variavel locais
            }

            Console.WriteLine("Enter the employee id that will have salary increase :");
            int procurarID = int.Parse(Console.ReadLine());



            Funcionario emp = list.Find(x => x.Id == procurarID); // depois de criada a lista e capturada as informações esse comando esta fazendo uma busca dentro da lista

            if (emp != null) // comando procura informações e ignora os locais vazios
            {
                Console.Write("Enter the percentage: ");
                double percentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentoDeSalario(percentagem);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionario obj in list) // comando procurar todos OBJ dentro da lista
            {
                Console.WriteLine(obj); // mostra  que foi encontrado junto ao override na classe funcionario
            }
        }
    }
}
