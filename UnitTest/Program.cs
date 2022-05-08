using System;
using Business;
using Domain;

namespace UnitTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Sitio sitio1 = new Sitio { Activo = true, Descripcion = "Cañadon Alfa" };
            //SitioBusiness sitioBusiness = new SitioBusiness();
            //sitioBusiness.SaveSitio(sitio1);
            var sitios = new SitioBusiness().GetSitios();
            foreach(var sitio in sitios)
            {
                Console.WriteLine("Id: " + sitio.Id.ToString() + " Sitio: " + sitio.Descripcion.ToString());
            }
            Console.ReadLine();
        }
    }
}
