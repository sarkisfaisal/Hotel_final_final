using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_string
{
    internal class mantencion_mes
    {
        
        private string fecha;
        private string obs;

        public mantencion_mes(string fecha, string obs)
        {
            
            
            this.fecha = fecha;
            this.obs = obs;
        }

        public void SetFecha(string fecha)
        {
            this.fecha = fecha;
            
        
        }

        public string GetFecha()
        { 
            return fecha;
        
        }

        public void SetObs(string obs)
        {
            this.obs = obs;


        }

        public string GetObs()
        {
            return obs;

        }

        

public mantencion_mes()
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
                string selectUsuario = "Select * from mantencion_mes";
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
                string insert = $"insert into mantencion_mes values ('{GetFecha()}','{GetObs()}')";
                SqlCommand comando = new SqlCommand(insert, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "mantencion_mes creado con éxito";
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
                string eliminar = $"delete from mantencion_mes where fecha = '{GetFecha()}'";
                SqlCommand comando = new SqlCommand(eliminar, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "Mantencoin mes eliminada con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }//fin eliminar


    }
}
