using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnit.Moq.Produtos
{
    public interface IVerificadorPrecoProduto
    {
        string VerificaPrecoProduto(Produto p);
    }
}
