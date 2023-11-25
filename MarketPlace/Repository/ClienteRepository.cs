using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.DBContext;
using MarketPlace.Repository.Interfaces;

namespace MarketPlace.Repository
{
    public class ClienteRepository : BaseRepository
    {
        public ClienteRepository(MarketContext marketContext) : base(marketContext)
        {
        }

        // Adicione métodos específicos de Cliente, se necessário
    }
}
