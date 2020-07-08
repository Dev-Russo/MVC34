using System;
using System.Collections.Generic;
using System.IO;

namespace MVC.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preço { get; set; }

        private const string PATH = "Database/produto.csv";

        public List<Produto> GetProdutos(){
            List<Produto> prod = new List<Produto>();

            string[] Lista = File.ReadAllLines(PATH);
            foreach(string linha in Lista){
                string[] dado = linha.Split(";");
                Produto p = new Produto();
                p.Codigo = Int32.Parse(Separar(dado[0]));
                p.Nome   = Separar(dado[1]);
                p.Preço  = float.Parse(Separar(dado[2]));

                prod.Add(p);
            }
            return prod;
        }
        public string Separar(string dado){
            return dado.Split("=")[1];
        }

        public override bool Equals(object obj)
        {
            //
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //
            
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
            Produto prod = (Produto) obj;
            return Codigo.Equals(prod.Codigo) && Nome.Equals(prod.Nome) && Preço.Equals(prod.Preço);
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return base.GetHashCode();
        }
    }   
}