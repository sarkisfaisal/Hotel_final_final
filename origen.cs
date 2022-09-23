using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hotel_final
{
    internal class origen
    {
       private string nombre;

        public origen(string nombre)
        {
            this.nombre = nombre;
        }

        public void setorigen(string nombre)
        { 
            this.nombre=nombre;
        
        }

        public string getorigen()
        {
            return nombre;

        }

        public origen()
        {
            //constructor vacío para acceder a las funciones que no requieran nada 
        }

        public DataTable Listar()
        {
            DataTable dtt;
            conexionbd c = new conexionbd();
            try
            {
                dtt = new DataTable();
                string selectUsuario = "Select * from origen";
                SqlCommand cmd = new SqlCommand(selectUsuario, c.conectarbd);
                cmd.CommandType = CommandType.Text;
                c.abrir();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dtt);
                c.cerrar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtt;
        }//fin listar

        public string insertar()
        {
            conexionbd c = new conexionbd();
            try
            {
                string insert = $"insert into origen values ('{setorigen}')";
                SqlCommand comando = new SqlCommand(insert, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "origen creado con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }// fin insertar

        public string Eliminar()
        {
            conexionbd c = new conexionbd();
            try
            {
                string eliminar = $"delete from origen where nombre = '{getorigen}'";
                SqlCommand comando = new SqlCommand(eliminar, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "origen eliminado con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }//fin eliminar
    }
}
