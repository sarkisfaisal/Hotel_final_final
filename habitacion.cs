using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hotel_final
{
    internal class habitacion
    {
        private int idtipo_habitacion {get;set;}
        private int idmantencion_mes { get; set; }
        private int numero { get; set; }
        private int piso { get; set; }
        private string disponible { get; set; }


        public habitacion(int idtipo_habitacion, int idmantencion_mes, int numero, int piso, string disponible)
        {
            this.idtipo_habitacion = idtipo_habitacion;
            this.idmantencion_mes = idmantencion_mes;
            this.numero = numero;
            this.piso = piso;
            this.disponible = disponible;
        }

        public int GetIdTipoHabitacion() 
        { 
            return idtipo_habitacion; 
        }
        public int GetIdMantencion_mes()
        {
            return idmantencion_mes;
        }
        public int Getnumero()
        {
            return numero;
        }
        public int Getpiso()
        {
            return piso;
        }
        public string Getdisponible()
        {
            return disponible;
        }

        public void SetidTipo_habitacion(int idtipohabitacion)
        {
            this.idtipo_habitacion = idtipohabitacion;
        }
        public void SetidMantencion_mes(int idmantencion)
        {
            this.idmantencion_mes= idmantencion;
        }
        public void Setnumero(int numero)
        {
            this.numero = numero;
        }
        public void Setdisponible(string disponible)
        {
            this.disponible= disponible;
        }
        public void Setpiso(int piso)
        {
            this.piso = piso;
        }

        public DataTable ListarDisponibles()
        {
            DataTable dtt;
            conexionbd c = new conexionbd();
            try

            {
                dtt = new DataTable();
                string selectdisponibles= "select idhabitacion, Tipo = tipo.tipo, numero, piso, disponible from habitacion hab inner join tipo_habitacion tipo on hab.idtipo_habitacion = tipo.idtipo_habitacion where disponible = 'Disponible'";
                SqlCommand cmd = new SqlCommand(selectdisponibles, c.conectarbd);
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
    }
}
