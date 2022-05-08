using Domain;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class SitioRepository 
    {
        private readonly IRepository<Sitio> _repo;

        public SitioRepository()
        {
            _repo = new RepositoryDB<Sitio>();
        }
        
        public List<Sitio> GetAll()
        {
            var query = "select * from sitio";
            return _repo.GetAll(query).ToList<Sitio>();
        }

        public int Create(Sitio entity)
        {
            //Probar esto 
            var query = "insert into Sitio (descripcion, activo) values(@Descripcion, @Activo) ";
            return _repo.Create(query, entity);
        }

        public int Update( Sitio entity)
        {
            var query = "UPDATE Sitio SET descripcion = @Descripcion, activo = @Activo WHERE id = @Id ";
            return _repo.Update(query, entity);
        }
    }
}
