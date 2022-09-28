using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_final
{
    internal class proveedores
    {
        private string rut;
        private string razon_social;

        public proveedores(string rut , string razon_social)
        {
            this.rut = rut;
            this.razon_social = razon_social;
        }
        public proveedores(string rut)
        {
            this.rut = rut;
        }

        public proveedores()
        {
        }

        public string get_rut()
        {
            return rut;
        }
        public string get_razon_social()
        {
            return razon_social;
        }
        public void setrut(string rut) {
            this.rut = rut;
        }
        public void setrazonsocial(string razonsocial) { 
            this.razon_social = razonsocial;
        }

        public DataTable Listar()
        {
            DataTable dtt;
            conexionbd c = new conexionbd();
            try
            {
                dtt = new DataTable();
                string selectUsuario = "Select * from proveedor";
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
        //camila
        public string insertar()
        {
            conexionbd c = new conexionbd();
            try
            {
                string insert = $"insert into proveedor values ('{get_rut()}','{get_razon_social()}')";
                SqlCommand comando = new SqlCommand(insert, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "Proveedor creado con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }//fin insertar

        public int Eliminar()
        {
            conexionbd c = new conexionbd();
            try
            {
                string eliminar = $"delete from proveedor where rut= '{get_rut()}'";
                SqlCommand comando = new SqlCommand(eliminar, c.conectarbd);
                c.abrir();
                int filas = comando.ExecuteNonQuery();
                c.cerrar();
                return filas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//fin eliminar
    }
}
