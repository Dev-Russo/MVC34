using System;
using MVC.Controllers;

namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prodController = new ProdutoController();
            prodController.BuscarPorPreço("6800");
            prodController.BuscarPorId(2);
            prodController.BuscarPorNome("Lespau");
            Models.Produto produto = new Models.Produto{Codigo = 3, Nome = "Lespau", Preço = 5500f};
            prodController.BuscarporProduto(produto);
        }
    }
}
