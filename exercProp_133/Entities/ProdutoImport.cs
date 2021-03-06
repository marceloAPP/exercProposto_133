﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace exercProp_133.Entities
{
    class ProdutoImport : Produto
    {
        public double TaxaAlfandega { get; private set; }

        public ProdutoImport()
        {
        }

        public ProdutoImport(string nome, double preco, double taxaAlfandega) : base(nome, preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        public override string PrecoEtiqueta()
        {
            return Nome 
                + " " 
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) 
                + $" (Taxa de Alfandega: R$ ${TaxaAlfandega.ToString("F2", CultureInfo.InvariantCulture)})";
        }

        public double TotalPrice()
        {
            return Preco + TaxaAlfandega;
        }
    }
}
