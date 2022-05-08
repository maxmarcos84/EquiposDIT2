using Dapper;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.Repository
{
    public class RepositoryDB<T> : IRepository<T> where T : class
    {
        //CREO QUE ESTO LO TENDRIA QUE BORRAR A LA MIERDA
        
        public IEnumerable<T> GetAll(string query)
        {
            using (var connection = new Factory().GetDBConnection)
            {
                return connection.Query<T>(query).ToList();
            }
        }
        
        //Ver en la documentacion de dapper como es el insert, update, delete

        int IRepository<T>.Create(string query, T entity)
        {
            using (var connection = new Factory().GetDBConnection)
            {
                return connection.Execute(query, entity);
            }
        }

        bool IRepository<T>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        T IRepository<T>.Get(int id)
        {
            throw new NotImplementedException();
        }

        //Tal vez habria que unificar el repositorio en acciones Execute (update, insert y delete juntas) y en acciones ToList (select algo)

        int IRepository<T>.Update(string query, T entity)
        {
            using (var connection = new Factory().GetDBConnection)
            {
                return connection.Execute(query, entity);
            }
        }
    }
}
