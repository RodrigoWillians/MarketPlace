using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Model
{
    public class ItemCarrinho
    {
        public int Id { get; set; }
        public String Quantidade { get; set; }
        public Double Total { get; set; }
        public Carrinho Carrinho { get; set; }
        public Produto Produto { get; set; }
    }
}