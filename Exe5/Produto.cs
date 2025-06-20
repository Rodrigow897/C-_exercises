using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe5
{
    public class Produto
    {
        public string? Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(string? nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome} -- Preço: R$ {Preco}");
        }
    }

}
