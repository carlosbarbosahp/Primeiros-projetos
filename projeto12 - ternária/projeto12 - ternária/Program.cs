using System;

namespace projeto12___ternária
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());


            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05; // essa expressão reduz o código, não sendo necessário utilizar o IF e ELSE
                                                                          // se for verdade se usa a primeira opção, se falso se usa a segunda opção 

            Console.WriteLine(desconto);


        }
    }
}
