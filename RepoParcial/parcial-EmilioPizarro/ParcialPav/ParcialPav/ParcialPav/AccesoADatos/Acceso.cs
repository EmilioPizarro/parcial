using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ParcialPav.AccesoADatos
{
    public class Acceso
    {
        public DataTable ObtenerJugador(int idJugador)
        {
            string cadenaBd = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaBd);

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = cn;

                cmd.CommandType = CommandType.Text;

                string consulta = "SELECT * FROM Jugadores WHERE Id='"+idJugador+"'";

                cn.Open();


                cmd.CommandText = consulta;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter();

                da.Fill(tabla);

                return tabla;



            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                cn.Close();
            }
        }
    }
}
