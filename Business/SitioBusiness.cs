using Domain;
using Repository.Interfaces;
using Repository.Repository;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class SitioBusiness
    {
        private readonly SitioRepository _repo;

        public SitioBusiness()
        {
            _repo = new SitioRepository();
        }

        public List<Sitio> GetSitios()
        {           
            return _repo.GetAll();
            //esto esta mal, para este caso particular tener un repositorio generico no me sirve
            //porque me obliga a poner sentencias sql en el business y se me mezclan las capas
        }

        public int SaveSitio(Sitio sitio)
        {
            return _repo.Create(sitio);
        }

        public int UpdateSitio(Sitio sitio)
        {
            return _repo.Update(sitio);
        }
    }
}
