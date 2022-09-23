using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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

        public DataTable Listar()
        {
            DataTable dtt;
            conexionbd c = new conexionbd();
            try
            {
                dtt = new DataTable();
                string select = "Select * from tipo_Habitacion";
                SqlCommand cmd = new SqlCommand(select, c.conectarbd);
                cmd.CommandType = CommandType.Text;
                c.abrir();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dtt);
                c.cerrar();
                return dtt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtt;
        }
    }//fin class tipo_habitacion
}//fin namespace Hotel_final
