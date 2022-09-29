using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_string
{
    internal class rol
    {
       // private int idrol;
        private string descripcion;

        public rol(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public void Setdescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public string Getdescripcion()
        {
            return descripcion;

        }

        public rol()
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
                string selectUsuario = "Select * from rol";
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

        public DataTable TraerFila(string Id) {

            DataTable dtt;
            conexionbd c = new conexionbd();
            try
            {
                dtt = new DataTable();
                string selectUsuario = $"Select top 1 * from rol where idrol = {Id}";
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
                string insert = $"insert into rol values ('{Getdescripcion()}')";
                SqlCommand comando = new SqlCommand(insert, c.conectarbd);
                c.abrir();
                int com = comando.ExecuteNonQuery();
                c.cerrar();
                return "Rol creado con éxito";
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
                string eliminar = $"delete from rol where descripcion = '{Getdescripcion()}'";
                SqlCommand comando = new SqlCommand(eliminar, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "Rol eliminado con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }//fin eliminar

        public string modificar(string descripcionAntigua)
        {
            conexionbd c = new conexionbd();
            try
            {
                string insert = $"update rol set descripcion = {Getdescripcion}  where descripcion = {descripcionAntigua}')";
                SqlCommand comando = new SqlCommand(insert, c.conectarbd);
                c.abrir();
                int com = comando.ExecuteNonQuery();
                c.cerrar();
                return "Rol creado con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }

}