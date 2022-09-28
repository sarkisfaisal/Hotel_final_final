using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_string
{
    internal class conexionbd

         //conexion sarkis = DESKTOP-MT7IKMQ
    {
        //string cadena = "Data Source=DESKTOP-MT7IKMQ; Initial Catalog=hotel_final; Integrated Security=True";
        //Coneccion camila: LAPTOP-5RVRRN9B\\SQLEXPRESS
        //Esta conexion solo funciona en mi pc, si usas tu cadena sólo comenta la mia
        string cadena = "Data Source= DESKTOP-MT7IKMQ; Initial Catalog=Hotel_string; Integrated Security=True";

        public SqlConnection conectarbd = new SqlConnection();

        public conexionbd()
        {
            conectarbd.ConnectionString = cadena;
        }

        public void abrir()
        {

            try
            {
                conectarbd.Open();
                Console.WriteLine("");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la BD " + ex.Message);

            }
        }//fin metodo abrir

        public void cerrar()
        {

            conectarbd.Close();

        }//fin metodo cerrar


    }//fin class conexionbd
}//fin namespace Login




