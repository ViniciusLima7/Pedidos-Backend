using System;
using System.Collections.Generic;
using System.Text;

namespace EXERCICIO01___ENUMERAÇÃO_E_COMPOSIÇÃO.Entities
{
    class Produto
    {
        public string NomeProduto { get; set; }
        public double PrecoProduto { get; set; }

        public Produto(string nomeProduto, double precoProduto)
        {
            NomeProduto = nomeProduto;
            PrecoProduto = precoProduto;
        }

        public Produto()
        {
        }
    }
}
