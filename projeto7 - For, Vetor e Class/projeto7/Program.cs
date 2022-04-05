using projeto7;
using System;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10]; // criado vetor com "10 caixas = quartos"


            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine()); // numero de quartos alugados foi capturado pela variavel "n"


            for (int i = 1; i <= n; i++) // o for vai parar quando atingir o numero digitado na variavel "n" acima

            {
                Console.WriteLine();

                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine(); // nome capturado

                Console.Write("Email: ");
                string email = Console.ReadLine(); // email capturado

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine()); // numero do quarto capturado

                vect[quarto] = new Estudante(nome, email); // colocando o nome e email dentro do numero do quarto escolhido no vetor
            }


            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:"); // a resposta para essa pergunta será o retorno do for criado abaixo

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null) // mostrará os quartos diferentes de nulos, ou seja só os que tem informações contidas dentros os de 10

                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}