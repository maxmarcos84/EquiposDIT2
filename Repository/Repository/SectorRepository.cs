using Domain;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class SectorRepository
    {
        private readonly IRepository<Sector> _repo;

        public SectorRepository()
        {
            _repo = new RepositoryDB<Sector>();
        }

        public List<Sector> GetAll()
        {
            var query = "Select * from sector";
            return _repo.GetAll(query).ToList<Sector>();
        }

        public int CrearSector(Sector sector)
        {
            var query = "INSERT INTO sector (nombre, activo) VALUES (@Nombre, @Activo)";
            return _repo.Create(query, sector);
        }

        public int UpdateSector(Sector sector)
        {
            var query = "UPDATE Sector set nombre = @Nombre, activo = @Activo WHERE id = @Id";
            return _repo.Update(query, sector);
        }

    }
}
