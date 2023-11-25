using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.DBContext;
using MarketPlace.Repository.Interfaces;

namespace MarketPlace.Repository
{
    public class CarrinhoRepository : BaseRepository
    {

        public CarrinhoRepository(MarketContext marketContext) : base(marketContext)
        {

        }
    }
}