using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_string
{
    internal class insumo
    {
        private int idpack;
        private int id_proveedor;
        private string nombre;
        private int cantidad;
        private string vencido;
        
        public insumo(int idpack, int idproveedor, string nombre, int cantidad, string vencido)
        {
            this.idpack = idpack;
            this.id_proveedor = idproveedor;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.vencido = vencido;

        }
        
        public insumo()
        {
            //Es para leer la clase sin necesidad de meterle variables
        }
        public int GetIdpack()
        {
            return idpack;
        }
        public int GetIdproveedor()
        {
            return id_proveedor;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public int GetCantidad()
        {
            return cantidad;
        }
        public string GetVencido()
        {
            return vencido;
        }
        public void setIdPack(int idpack) 
        {
            this.idpack = idpack;
        }
        public void setIdproveedor(int idproveedor)
        {
            this.id_proveedor = idproveedor;
        }
        public void setnombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setcantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }
        public void setvencido(string vencido)
        {
            this.vencido = vencido;
        }
        public DataTable Listar()
        {
            DataTable dtt;
            conexionbd c = new conexionbd();
            try
            {
                dtt = new DataTable();
                string selectUsuario = "Select * from insumo";
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
                string insert = $"insert into insumo values ({GetIdpack()},{GetIdproveedor()},'{GetNombre()}',{GetCantidad()},'{GetVencido()}')";
                SqlCommand comando = new SqlCommand(insert, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "Insumo agregado con éxito";
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
                string eliminar = $"delete from insumo where = '{GetNombre()}'";
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
