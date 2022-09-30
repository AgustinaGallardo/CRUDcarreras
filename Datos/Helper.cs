using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CRUDcarreras.Dominio;

namespace CRUDcarreras.Datos
{
    internal class Helper
    {
        SqlConnection cnn = new SqlConnection(Properties.Resources.cnnCRUDcarreras);
        private static Helper instancia;

        public static Helper ObtenerInstancia()
        {
            if(instancia == null)
                instancia = new Helper();
            return instancia;
        }

        public int ObtenerProximo(string sp_nombre,string OutPut)
        {
            cnn.Open();
            SqlCommand cmdNext = new SqlCommand();
            cmdNext.Connection=cnn;
            cmdNext.CommandText=sp_nombre;
            cmdNext.CommandType= CommandType.StoredProcedure;

            SqlParameter pOutPut = new SqlParameter();
            pOutPut.ParameterName=OutPut;
            pOutPut.Direction=ParameterDirection.Output;
            pOutPut.DbType=DbType.Int32;

            cmdNext.Parameters.Add(pOutPut);

            cmdNext.ExecuteNonQuery();
            cnn.Close();
            return (int)pOutPut.Value;
        }

        public DataTable CargarCombo(string sp_nombre)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmdCombo = new SqlCommand();

            cmdCombo.Connection=cnn;
            cmdCombo.CommandText=sp_nombre;
            cmdCombo.CommandType=CommandType.StoredProcedure;

            tabla.Load(cmdCombo.ExecuteReader());
            cnn.Close();
            return tabla;
        }

        public bool ConfirmasCarrera(Carrera oCarrera)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                SqlCommand cmdMaestro = new SqlCommand();
                cnn.Open();
                t = cnn.BeginTransaction();

                cmdMaestro.Transaction= t;
                cmdMaestro.Connection= cnn;                
                cmdMaestro.CommandType= CommandType.StoredProcedure;
                cmdMaestro.CommandText= "INSERT_MAESTRO";

               
                cmdMaestro.Parameters.AddWithValue("@nombre", oCarrera.Nombre);
                cmdMaestro.Parameters.AddWithValue("@titulo", oCarrera.Titulo);

                SqlParameter pOutPut = new SqlParameter();
                pOutPut.ParameterName="@idCarrera";
                pOutPut.DbType= DbType.Int32;
                pOutPut.Direction= ParameterDirection.Output;

                cmdMaestro.Parameters.Add(pOutPut);

                cmdMaestro.ExecuteNonQuery();

                int idCarrera = (int)pOutPut.Value;

                foreach (DetalleCarrera dt in oCarrera.Detalles)
                {
                    SqlCommand cmdDetalle = new SqlCommand();
                    cmdDetalle.Connection=cnn;
                    cmdDetalle.Transaction= t;
                    cmdDetalle.CommandType=CommandType.StoredProcedure;
                    cmdDetalle.CommandText="INSERT_DETALLE";

                    cmdDetalle.Parameters.AddWithValue("@idCarrera", idCarrera);
                    cmdDetalle.Parameters.AddWithValue("@anioCursado", dt.AnioCursado);
                    cmdDetalle.Parameters.AddWithValue("@cuatrimestre", dt.Cuatrimestre);
                    cmdDetalle.Parameters.AddWithValue("@idMateria", dt.Materia.IdMateria);

                    
                    cmdDetalle.ExecuteNonQuery();
                    
                }
                t.Commit();

            }
            catch (Exception)
            {
                if (t != null)
                {
                    t.Rollback();
                    ok=false;
                }
                return ok;
            }
            finally
            {
                if (cnn !=null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return ok;
        }
    }
}
