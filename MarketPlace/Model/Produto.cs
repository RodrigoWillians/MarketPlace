using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public String Descricao { get; set; }
        public Double Preco { get; set; }
        public String Imagem { get; set; }
        public String Status { get; set; }
        public Vendedor Vendedor { get; set; }
        public Categoria Categoria { get; set; }

    }
}