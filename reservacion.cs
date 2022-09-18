using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_final
{
    internal class reservacion
    {   
        string identificacion { get; set; }
        int idorigen { get; set; }
        int idhabitacion { get; set; }
        string llegada { get; set; }
        string salida { get; set; }
        string obs { get; set; }

        public reservacion(string identificacion, int idorigen, int idhabitacion, string llegada, string salida,string obs)
        {
            this.identificacion = identificacion;
            this.idorigen = idorigen;
            this.idhabitacion = idhabitacion;
            this.llegada = llegada;
            this.salida = salida;
            this.obs = obs;
        }
    }
}
