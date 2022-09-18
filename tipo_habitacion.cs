using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_final
{
    internal class tipo_habitacion
    {
        private string tipo { get; set; }
        public tipo_habitacion(string tipo)
        { 
            this.tipo = tipo;
        
        }
    }//fin class tipo_habitacion
}//fin namespace Hotel_final
