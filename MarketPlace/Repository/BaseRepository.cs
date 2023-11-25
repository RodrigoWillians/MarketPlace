using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketPlace.DBContext;

namespace MarketPlace.Repository.Interfaces
{
    public class BaseRepository : IBaseRepository
     {
        private readonly MarketContext _MarketContext;
        public BaseRepository(MarketContext MarketContext)
        {
            _MarketContext = MarketContext;
        }

        public IEnumerable<T> FindAll<T>() where T : class
        {
            return _MarketContext.Set<T>().ToList();
        }

        public T FindById<T>(object id) where T : class
        {
            return _MarketContext.Find<T>(id);
        }

        public void Add<T>(T entity) where T : class {
            _MarketContext.Add(entity);
        }

        public void AddRange<T>(List<T> entity) where T : class {
            _MarketContext.AddRange(entity);
        }

        public void Update<T>(T entity) where T : class {
            _MarketContext.Update(entity);
        }

        public async Task<bool> Save() {
            return await _MarketContext.SaveChangesAsync() > 0;
        }

                public void Delete<T>(T entity) where T : class
        {
            _MarketContext.Remove(entity);
        }
    }
}