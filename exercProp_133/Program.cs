using System;
using System.Collections.Generic;
using System.Globalization;
using exercProp_133.Entities;

namespace exercProp_133
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> prod = new List<Produto>();

            Console.WriteLine("Digite quantidade de produtos: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"\nDados do Produto {num}: ");
                Console.Write("Produto Comum/Usado/Importado? (C/U/I): ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome:");
                string nome = Console.ReadLine();

                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'U')
                {
                    Console.Write("Data de Fabricação (DD/MM/AAAA): ");
                    DateTime dataFabricacao = DateTime.Parse(Console.ReadLine()); 
                }
            }
            
        }
    }
}
