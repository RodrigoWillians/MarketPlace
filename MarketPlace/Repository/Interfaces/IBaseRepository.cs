using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MarketPlace.Repository.Interfaces
{
    public interface IBaseRepository
    {
        public IEnumerable<T> FindAll<T>() where T : class;
        public T FindById<T>(object id) where T : class;
        public void Add<T>(T entity) where T : class;

        public void Update<T>(T entity) where T : class;

        Task<bool> Save();

        public void AddRange<T>(List<T> entity) where T : class;
        void Delete<T>(T entity) where T : class;
    }
}