using System;
using System.Collections.Generic;
using System.Globalization;

namespace exercProp_133.Entities
{
    class ProdutoUsed : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsed()
        {
        }

        public ProdutoUsed(string nome, double preco, DateTime dataFabricacao) : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string PrecoEtiqueta()
        {
            return Nome
                + " (Usado) R$"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " (Data de Fabricação: " 
                + DataFabricacao.ToString("dd/MM/yyyy")
                + ")";  
        }
    }
}
