using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Repositories
{
    public interface IRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        T GetByName(string name);

        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        List<T> GetByMovie(int movieId);

        bool HasConflict(T entity);

    }

}
