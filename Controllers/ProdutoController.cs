using System.Collections.Generic;
using System.Linq;
using MVC.Models;
using MVC.Views;

namespace MVC.Controllers
{
    public class ProdutoController
    {
        Produto produtomodel = new Produto();
        ProdutoViews viewsproduto = new ProdutoViews();

        public void Listar(){
            viewsproduto.MostrarNoConsole( produtomodel.GetProdutos() );
        }
        public void BuscarPorPreço(string _preco){
            List<Produto> listaProdutos = produtomodel.GetProdutos();
            listaProdutos = listaProdutos.FindAll(x => x.Preço == float.Parse(_preco)).ToList(); 
            viewsproduto.MostrarNoConsole(listaProdutos);
        }
        public void BuscarPorId(int _codigo){
            List<Produto> listaProdutos = produtomodel.GetProdutos();
            listaProdutos = listaProdutos.FindAll(prod => prod.Codigo == _codigo).ToList(); 
            viewsproduto.MostrarNoConsole(listaProdutos);
        }
        public void BuscarPorNome(string _Nome){
            List<Produto> listaProdutos = produtomodel.GetProdutos();
            listaProdutos = listaProdutos.FindAll(prod => prod.Nome == _Nome).ToList(); 
            viewsproduto.MostrarNoConsole(listaProdutos);
        }
        public void BuscarporProduto(object obj){
            List<Produto> listaProdutos = produtomodel.GetProdutos();
            listaProdutos = listaProdutos.FindAll(prod => prod.Equals(obj));
            viewsproduto.MostrarNoConsole(listaProdutos);
        }
    }
}