using Domain;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class SectorBusiness
    {
        private readonly SectorRepository _repo;

        public SectorBusiness()
        {
            _repo = new SectorRepository();
        }

        public List<Sector> GetSectores()
        {
            return _repo.GetAll();
        }

        public int SaveSector(Sector sector)
        {
            return _repo.CrearSector(sector);
        }

        public int UpdateSector(Sector sector)
        {
            return _repo.UpdateSector(sector);
        }

    }
}
