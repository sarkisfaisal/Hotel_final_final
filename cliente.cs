using System;using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_final
{
    internal class cliente
    {

        private int idpack;
        private int idstaff;
        private string nombre;
        private string apellido;
        private string nacionalidad;
        private string fecha_nacimiento;
        private string estado;



        public cliente(int idpack, int idstaff, string nombre, string apellido, string nacionalidad, string fecha_nacimiento, string estado)
        {
            this.idpack = idpack;
            this.idstaff = idstaff;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
            this.fecha_nacimiento = fecha_nacimiento;
            this.estado = estado;
        }


            public void SetIdPack(int idpack)
            {
                this.idpack = idpack;
        
            }

            public int GetIdPack()
            { 
                return this.idpack;
            }

        public void SetIdStaff(int idstaff)
        {
            this.idstaff = idstaff;

        }

        public int GetIdStaff()
        {
            return idstaff;
        }

        public void SetIdNombre(string nombre)
        {
            this.nombre = nombre;

        }

        public string GetIdNombre()
        {
            return nombre;
        }

        public void SetIdApellido(string apellido)
        {
            this.apellido = apellido;

        }

        public string GetIdApellido()
        {
            return apellido;
        }

        public void SetNacionalidad(string nacionalidad)
        {
            this.nacionalidad = nacionalidad;

        }

        public string GetIdNacionalidad()
        {
            return nacionalidad;
        }

        public void SetIdFechaNacimiento(string fecha_nacimiento)
        {
            this.fecha_nacimiento = fecha_nacimiento;

        }

        public string GetFechaNacimiento()
        {
            return fecha_nacimiento;
        }

        public void SetEstado(string estado)
        {
            this.estado = estado;
        }

        public string GetEstado()
        {
            return estado;

        }


         public cliente()
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
                string selectUsuario = "Select * from cliente";
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
        }// fin listar

        public string insertar()
        {
            conexionbd c = new conexionbd();
            try
            {   string mostrar_pack = $"select * from pack";
                SqlCommand cmd_mostrar_pack = new SqlCommand(mostrar_pack, c.conectarbd);
                c.abrir();
                cmd_mostrar_pack.ExecuteNonQuery();
                c.cerrar();
                Console.WriteLine("seleccione un pack");
                int pack = int.Parse(Console.ReadLine());
                //string insert = $"insert into rol values ('{this.descripcion}')";
                //SqlCommand comando = new SqlCommand(insert, c.conectarbd);
                //c.abrir();
                //comando.ExecuteNonQuery();
                //c.cerrar();
                return "cliente creado con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }//fin insertar

        /*public string Eliminar()
        {
            conexionbd c = new conexionbd();
            try
            {
                string eliminar = $"delete from rol where descripcion = '{this.descripcion}'";
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
        }//fin eliminar */



    }//fin class cliente
}//fin namespace
