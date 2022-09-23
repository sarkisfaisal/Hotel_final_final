using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_final
{
    internal class pack
    {
        private string descripcion;
        private DateTime fecha;

        public pack(string descripcion) 
        {
            this.descripcion = descripcion;
        }

        public string Getdescripcion() { 
            return descripcion;
        }
        public DateTime Getfecha()
        {
            return fecha;
        }
        public void setdescripcion(string descripcion) { 
            this.descripcion = descripcion;
        }
        public void setfecha(DateTime fecha) {
        this.fecha = fecha;
        }

        public DataTable Listar()
        {
            DataTable dtt;
            conexionbd c = new conexionbd();
            try
            {
                dtt = new DataTable();
                string selectUsuario = "Select * from pack";
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
        }

        public string insertar()
        {
            conexionbd c = new conexionbd();
            try
            {
                string insert = $"insert into pack values ('{Getdescripcion}')";
                SqlCommand comando = new SqlCommand(insert, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "Rol creado con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Eliminar()
        {
            conexionbd c = new conexionbd();
            try
            {
                string eliminar = $"delete from pack where descripcion = '{Getdescripcion}'";
                SqlCommand comando = new SqlCommand(eliminar, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "Pack eliminado con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
