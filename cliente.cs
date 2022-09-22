using System;
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

        // public cliente()
        //{
        //constructor vacío para acceder a las funciones que no requieran nada 
        //}

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
            }

        }
    }//fin class cliente
}//fin namespace
