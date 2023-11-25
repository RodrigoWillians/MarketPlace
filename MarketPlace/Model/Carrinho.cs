using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Model
{
    public class Carrinho
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public double ValorTotal { get; set; }
        public int StatusPedido { get; set; }
        public Cliente Cliente { get; set; } // Propriedade de navegação
        public List<Produto> Produtos { get; set; }
    }
}