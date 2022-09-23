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
        private string identificacion;
        private int idpack;
        private int idstaff;
        private string nombre;
        private string apellido;
        private string nacionalidad;
        private string fecha_nacimiento;
        private string estado;



        public cliente(string identificacion, int idpack, int idstaff, string nombre, string apellido, string nacionalidad, string fecha_nacimiento, string estado)
        {
            this.identificacion = identificacion;
            this.idpack = idpack;
            this.idstaff = idstaff;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
            this.fecha_nacimiento = fecha_nacimiento;
            this.estado = estado;
        }


            

        

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;

        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetApellido(string apellido)
        {
            this.apellido = apellido;

        }

        public string GetApellido()
        {
            return apellido;
        }

        public void SetNacionalidad(string nacionalidad)
        {
            this.nacionalidad = nacionalidad;

        }

        public string GetNacionalidad()
        {
            return nacionalidad;
        }

        public void SetFechaNacimiento(string fecha_nacimiento)
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
// ----------------------- FUNCION INSERTAR CLIENTE PENDIENTE -------
        public string insertar()
        {
            conexionbd c = new conexionbd();
            try
            {
                Console.WriteLine("ingrese identificacion");
                String identificacion = Console.ReadLine();
                Console.WriteLine("selecciones pack ");
                Console.WriteLine("1 pack 1 ");
                Console.WriteLine("2 pack 2 ");
                Console.WriteLine("3 pack 3 ");
                int idpack = int.Parse(Console.ReadLine());
                Console.WriteLine("seleccione staff ");
                Console.WriteLine("1 staff piso 6 diurno ");
                Console.WriteLine("2 tstaff piso 7 vespertino ");
                Console.WriteLine("3 tstaff piso 9 diurno");
                int idstaff = int.Parse(Console.ReadLine());
                
                string insert = $"insert into cliente values ('{idpack}','{idstaff}''{SetNombre}''{SetApellido}''{SetNacionalidad}''{SetFechaNacimiento}''{SetEstado}')";
                SqlCommand comando = new SqlCommand(insert, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                
                c.cerrar();
                return "cliente creado con éxito";
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
                string eliminar = $"delete from cliente where identificacion = '{identificacion}'";
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



    }//fin class cliente
}//fin namespace
