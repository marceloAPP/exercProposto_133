using System;
using System.Collections.Generic;
using System.Text;

namespace exercProp_133.Entities
{
    class ProdutoUsed : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsed()
        {
        }

        public ProdutoUsed(string nome, double preco, DateTime dataFrabicacao) : base(nome, preco)
        {
            DataFabricacao = DataFabricacao;
        }

        public override string PrecoEtiqueta()
        {
            return Nome 
                + " (Usado) R$" 
                + Preco + $"(Data de Fabricação: {DataFabricacao.ToShortDateString()})";  
        }
    }
}
