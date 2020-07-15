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
                Console.WriteLine($"\nDados do Produto {i}: ");
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

                    prod.Add(new ProdutoUsed(nome, preco, dataFabricacao));
                }
                else if (ch == 'I')
                {
                    Console.Write("Taxa de Alfandega: ");
                    double taxaAlfandega = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    prod.Add(new ProdutoImport(nome, preco, taxaAlfandega));
                }
                else
                {
                    prod.Add(new Produto(nome, preco));
                }
            }

            Console.WriteLine("\nPREÇOS ETIQUETAS: ");
            foreach (var item in prod)
            {
                Console.WriteLine(item.PrecoEtiqueta());
            }
        }
    }
}
