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
        private string tipo; //{ get => tipo; set => tipo =value; }
        public tipo_habitacion(string tipo)
        { 
            this.tipo = tipo;
        
        }

        public string GetTipoHabitacion()
        {
            return tipo;
        
        }

        public void SetTipoHabitacion(string tipo)
        {
            this.tipo = tipo;
        
        }
    }//fin class tipo_habitacion
}//fin namespace Hotel_final
