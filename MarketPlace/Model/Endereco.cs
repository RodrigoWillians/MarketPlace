using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Model
{
    public class Endereco
    {
        public int Id { get; set; }
        public String Cep { get; set; }
        public String Logradouro { get; set; }
        public String cidade { get; set; }
        public String numero { get; set; }

    }
}