using System;
using System.Collections.Generic;
using System.Text;
using XUnit.Moq.Produtos;

namespace Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }

    public class VerificadorPrecoProduto : IVerificadorPrecoProduto
    {
        public string VerificaPrecoProduto(Produto p)
        {
            if (p.Preco > 100)
                return "Produto caro!";
            else if (p.Preco <= 100 && p.Preco > 40)
                return "Produto na média de preço!";
            else
                return "Produto barato!";
        }
    }

}