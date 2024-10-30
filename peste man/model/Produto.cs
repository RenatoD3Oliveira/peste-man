using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peste_man.model
{
    internal class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(int id, string nomeProduto, float preco, int quantidade)
        {
            Id = id;
            NomeProduto = nomeProduto;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}
