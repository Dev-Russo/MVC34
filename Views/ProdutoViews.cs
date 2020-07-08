using System;
using System.Collections.Generic;
using MVC.Models;

namespace MVC.Views
{
    public class ProdutoViews
    {
        public void MostrarNoConsole(List<Produto> lista){
            foreach(Produto item in lista){
                Console.WriteLine($"R$ {item.Preço} - {item.Nome}");
            }
        }
    }
}