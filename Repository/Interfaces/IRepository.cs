using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(string query);

        T Get(int id);

        int Create(string query,T entity);

        int Update(string query, T entity);

        bool Delete(int id);

        //IEnumerable<T> GetAll(string query); esta manera se puede implementar, para recibir query con
        //filtros y usar para todo tipo de consulta que obtenga una lista de obj
    }
}
