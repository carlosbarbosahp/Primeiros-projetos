using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine()); // captura da quantidade de colunas e linhas e ser criado

            int[,] mat = new int[n, n]; //criado a matriz com nome MAT e linhas e colunas N

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' '); // criado vetor que armazena temporariamente os dados informados
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]); // o vetor passara os dados para a matriz na posição J, até que J senha menor que N, depois ele voltara para o primeiro FOR
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " "); // como foi informado a posição I+I ele retornara o mesm numero conforme roda o FOR, assim é possivel pegar s numeros diagonais 
            }
            Console.WriteLine();

            int count = 0; // count criado para somar com resutado do FOR para obter os numeros negativos
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++) // FOR em conjunto com FOR acima, rodara todos os campos com dados
                {
                    if (mat[i, j] < 0) // mostrará numeros menores que 0
                    {
                        count++; // count criado com 0 somara com IF ao encontrar os numeros menores que 0
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count); // resultad que mostrará os numeros negativos

        }
    }
}