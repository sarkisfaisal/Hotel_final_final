using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_final
{
    internal class turno
    {
        string tipo;

        public turno(string tipo)
        {
            this.tipo = tipo;
        }

        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public string GetTipo()
        {
            return tipo;
        }

        public turno()
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
                string selectUsuario = "Select * from turno";
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
                string insert = $"insert into turno values ('{SetTipo}')";
                SqlCommand comando = new SqlCommand(insert, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "Turno creado con éxito";
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
                string eliminar = $"delete from rol where tipo = '{GetTipo}'";
                SqlCommand comando = new SqlCommand(eliminar, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "Turno eliminado con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }//fin eliminar


    }
}

