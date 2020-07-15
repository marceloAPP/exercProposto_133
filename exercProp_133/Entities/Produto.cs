using System;
using System.Collections.Generic;
using System.Globalization;

namespace exercProp_133.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int _produto;

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string PrecoEtiqueta()
        {
            return Nome + " R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture);                    
        }
    }
}
