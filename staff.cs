using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_final
{
    internal class staff
    {
        private int idturno;
        private string descripcion;

        public staff(int idturno, string descripcion)
        { 
            this.idturno = idturno;
            this.descripcion = descripcion;
        
        }

        public void SetDescripcion(string descripcion)
        {

            this.descripcion = descripcion;
        
        }

        public string GetDescripcion()
        {
            return descripcion;
        
        }



public staff()
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
                Console.WriteLine("seleccione id turno");
                string idturno = Console.ReadLine();
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

            try

            {


                dtt = new DataTable();
                string selectUsuario = "Select * from staff";
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
                
                string insert = $"insert into staff values ('{idturno}','{SetDescripcion}')";
                SqlCommand comando = new SqlCommand(insert, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "staff creado con éxito";
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
                string eliminar = $"delete from staff where descripcion = '{GetDescripcion}'";
                SqlCommand comando = new SqlCommand(eliminar, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "staff eliminado con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }//fin eliminar


    }
}
