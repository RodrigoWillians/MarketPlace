using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public long Cpf { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public Endereco Endereco { get; set; }
    }
}