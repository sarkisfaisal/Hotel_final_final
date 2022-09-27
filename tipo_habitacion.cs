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

        public tipo_habitacion()
        { 
        
        }

        public DataTable Listar()
        {
            DataTable dtt;
            conexionbd c = new conexionbd();
            try
            {
                dtt = new DataTable();
                string select = "Select * from tipo_habitacion";
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
        }// fin listar

        public string insertar()
        {
            conexionbd c = new conexionbd();
            try
            {
                string insert = $"insert into tipo_habitacion values ('{GetTipoHabitacion()}')";
                SqlCommand comando = new SqlCommand(insert, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "Tipo creado con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }//fin insertar

        public string Eliminar()
        {
            conexionbd c = new conexionbd();
            try
            {
                string eliminar = $"delete from tipo_habitacion where tipo = '{GetTipoHabitacion()}'";
                SqlCommand comando = new SqlCommand(eliminar, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "Tipo eliminado con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }// fin eliminar

    }//fin class tipo_habitacion
}//fin namespace Hotel_final
