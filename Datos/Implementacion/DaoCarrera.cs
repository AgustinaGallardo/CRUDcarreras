using CRUDcarreras.Datos.Intefaz;
using CRUDcarreras.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDcarreras.Datos.Implementacion
{
    internal class DaoCarrera : IDaoCarrera
    {
        public List<Materia> ObtenerMaterias()
        {
            List<Materia> lst = new List<Materia>();
            string sp_nombre = "ObtenerCombo";
            DataTable tb = Helper.ObtenerInstancia().CargarCombo(sp_nombre);
            foreach(DataRow dr in tb.Rows)
            {
                int id =int.Parse(dr["idMateria"].ToString());
                string nombre= dr["Nombre"].ToString();
                Materia aux = new Materia(id, nombre);
                lst.Add(aux);
            }
            return lst;
        }

        public int ObtenerProximo()
        {
            string sp_nombre = "ObtenerProximo";
            string OutPut = "@Next";

            return Helper.ObtenerInstancia().ObtenerProximo(sp_nombre,OutPut);
        }
    }
}
