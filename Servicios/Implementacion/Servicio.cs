using CRUDcarreras.Datos.Implementacion;
using CRUDcarreras.Datos.Intefaz;
using CRUDcarreras.Dominio;
using CRUDcarreras.Servicios.Intefaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDcarreras.Servicios.Implementacion
{
    internal class Servicio : IServicio
    {
        private IDaoCarrera dao;

        public Servicio()
        {
            dao = new DaoCarrera();
        }

        public List<Materia> ObtenerMaterias()
        {
            return dao.ObtenerMaterias();
        }

        public int ObtenerProximo()
        {
            return dao.ObtenerProximo();
        }
    }
}
