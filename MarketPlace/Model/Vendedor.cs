using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Model
{
    public class Vendedor
    {
        public int Id { get; set; }
        public String RazaoSocial { get; set; }
        public String NomeFantasia { get; set; }
        public long Cnpj { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public Decimal Comissao { get; set; }
        public Endereco Endereco { get; set; }
    }
}