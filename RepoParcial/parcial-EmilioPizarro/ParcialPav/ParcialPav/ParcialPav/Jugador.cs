using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPav
{
    public class Jugador
    {
        public int idJugador { get; set; }
        public string nombreJugador { get; set; }
        public int posicionJugador { set; get; }

        public Jugador(int idJug,string nombre, int posicion)
        {
            idJugador = idJug;
           nombreJugador= nombre;
           posicionJugador = posicion;
        }
    }

   

    
}
