using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_final
{
    internal class habitacion
    {
        private int idtipo_habitacion {get;set;}
        private int idmantencion_mes { get; set; }
        private string numero { get; set; }
        private string piso { get; set; }
        private string disponible { get; set; }


        public habitacion(int idtipo_habitacion, int idmantencion_mes, string numero, string piso, string disponible)
        {
            this.idtipo_habitacion = idtipo_habitacion;
            this.idmantencion_mes = idmantencion_mes;
            this.numero = numero;
            this.piso = piso;
            this.disponible = disponible;
        }
    }
}
