using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using ParcialPav.AccesoADatos;

namespace ParcialPav
{
    public partial class AltaEquipo : Form
    {
        public AltaEquipo()
        {
            InitializeComponent();
        }

        private void AltaEquipo_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString();
            CargarComboCategorias();
            CargarComboPosicion();
            ObtenerNroEquipo();
            
        }

        private void btnBuscarJugador_Click(object sender, EventArgs e)
        {
            if (txtNroJugador.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un numero de jugador");
            }
            else
            {
                ObtenerJugador(int.Parse(txtNroJugador.Text));


                
            }
        }

        private void btnAgregarJugador_Enter(object sender, EventArgs e)
        {

        }

        public void CargarComboCategorias()
        {
            string cadenaBd = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaBd);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Categorias ";

                cmd.Parameters.Clear();


                cmd.CommandType = CommandType.Text;

                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                cmbCategorias.DataSource = tabla;
                cmbCategorias.ValueMember = "Id";
                cmbCategorias.DisplayMember = "Nombre";
               



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

        public void CargarComboPosicion()
        {
            string cadenaBd = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaBd);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Posiciones";

                cmd.Parameters.Clear();


                cmd.CommandType = CommandType.Text;

                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                cmbPosicion.DataSource = tabla;
                cmbPosicion.ValueMember = "Id";
                cmbPosicion.DisplayMember = "Nombre";




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

        public void limpiarCampos()
        {
            txtNombreDeEquipo.Text = "";
            txtNroJugador.Text = "";
            txtNombreJugador.Text = "";
            txtNroNuevoEquipo.Text = "";
        }


        public void ObtenerJugador(int idJugador)
        {
            string cadenaBd = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaBd);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Jugadores WHERE Id = '"+idJugador+"'";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);
                
                if(tabla.Rows.Count > 0)
                {
                    txtNombreJugador.Text = tabla.Rows[0]["Nombre"].ToString();
                }


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

        public void ObtenerNroEquipo()
        {
            string cadenaBd = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlConnection cn = new SqlConnection(cadenaBd);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT MAX(Id) FROM Equipos";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;
                
                int numeroNuevoId = (int)cmd.ExecuteScalar();

                numeroNuevoId++;

                txtNroNuevoEquipo.Text = numeroNuevoId.ToString();


                




                
               


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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreJugador.Text.Equals(""))
            {
                MessageBox.Show("No hay un jugador cargado");

            }
            else
            {
                int numeroid = int.Parse(txtNroJugador.Text);
                string nombreJugador = txtNombreJugador.Text;
                int numeroPosicion = int.Parse(cmbPosicion.SelectedValue.ToString());
                dgrEquipo.Rows.Add(numeroid, nombreJugador, numeroPosicion);
            }
        }

        public void btnConfirmarEquipo_Click(object sender, EventArgs e)
        {
            if (txtNombreDeEquipo.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre de equipo");
            }
            else
            {
                List<Jugador> jugadorList = new List<Jugador>();

                for (int i = 0; i < dgrEquipo.Rows.Count; i++)
                {
                    int nroJugador = int.Parse(dgrEquipo.Rows[i].Cells["NroJugador"].Value.ToString());
                    string nombreJug = dgrEquipo.Rows[i].Cells["NombreJugador"].Value.ToString();
                    int numeroPosicion = int.Parse(dgrEquipo.Rows[i].Cells["NroPosicion"].Value.ToString());

                    Jugador nuevoJugador = new Jugador(nroJugador, nombreJug, numeroPosicion);

                    jugadorList.Add(nuevoJugador);

                }
                string nombreEquipo = txtNombreDeEquipo.Text;

                int idEquipo = int.Parse(txtNroNuevoEquipo.Text);

                string fecha = DateTime.Now.ToString();

                bool resultado = AltaNuevoJugador(idEquipo, fecha, jugadorList, nombreEquipo);

                if (resultado)
                {
                    MessageBox.Show("Transaccion Exitosa");
                    cmbCategorias.SelectedIndex = -1;
                    cmbPosicion.SelectedIndex = -1;
                    limpiarCampos();
                    dgrEquipo.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Transaccion Fallida");
                }
            }
            

            
           
           
        }

        public static bool AltaNuevoJugador(int idEquipo, string fecha, List<Jugador> ListaJugador, string nombreEqui)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

            SqlTransaction objetoTransaccion = null;

            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Equipos VALUES(@NombreEquipo,@FechaCreacion)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreEquipo", nombreEqui);
                cmd.Parameters.AddWithValue("@FechaCreacion", fecha);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                objetoTransaccion = cn.BeginTransaction("AltaDeEquipo"); 

                
                cmd.Transaction = objetoTransaccion; 


                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                foreach(Jugador player in ListaJugador)
                {
                    string consul = "INSERT INTO JugadoresPorEquipos VALUES(@IdJugador,@IdEquipo, @FechaAsignacion, @IdPosicion)";

                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@IdJugador", player.idJugador);
                    cmd.Parameters.AddWithValue("@IdEquipo", idEquipo);
                    cmd.Parameters.AddWithValue("@FechaAsignacion",fecha);
                    cmd.Parameters.AddWithValue("@IdPosicion",player.posicionJugador);

                    cmd.CommandText = consul;

                    cmd.ExecuteNonQuery();


                }

                objetoTransaccion.Commit();

                return true;

            }
            catch (Exception)
            {
                objetoTransaccion.Rollback();
                return false;

                throw;
            }
            finally
            {
                cn.Close();
            }
        }


    }
}
