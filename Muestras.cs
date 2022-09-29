using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_final
{
    internal class Muestras
    {
        private int idpack;

        // ----------------------INICIO MOSTRAR ROLES--------------------------- 
        public void mostrar_roles() 
        {
           
            //se traen los roles de la base de datos y se muestran en pantalla, si no hay roles muestra el mensaje "no hay roles registrados"
            rol rol = new rol("");
            DataTable dtt = rol.Listar();
            if (dtt.Rows.Count > 0)
            {
                Console.WriteLine("Id \t Descripción");
                int i = 0;
                foreach (DataRow ren in dtt.Rows)
                {
                    Console.WriteLine(ren[0] + "\t" + ren[1]);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No hay roles registrados");
            }
            Console.ReadLine();
        }
        // -------------------- FIN MOSTRAR ROLES --------------------------------
        
        // -------------------- INICIO MOSTRAR TIPO PAGO -------------------------
        public void mostrar_tipo_pago()
        {
            tipo_pago tipo_pago = new tipo_pago("");
            DataTable dtt = tipo_pago.Listar();
            if (dtt.Rows.Count > 0)
            {
                Console.WriteLine("Descripción");
                int i = 0;
                foreach (DataRow ren in dtt.Rows)//la variable ren, ahora contendra el valor de cada una de las filas de dtt.
                {
                    Console.WriteLine(ren[0] + "\t" + ren[1]);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No hay tipos de pago registrados");
            }
            Console.ReadLine();
        }
        //---------------------- FIN MOSTRAR TIPO PAGO ---------------------------

        //----------------------INICIO MOSTRAR HABITACIONES-----------------------
        // Camila: se traen los tipo_habitacion de la base de datos y se muestran en pantalla,
        // si no hay registros se retorna un mensaje "Tipo de pago no registrado".
        public void mostrar_habitaciones_disponibles()
        {
          habitacion hab = new habitacion(0, 0, 0, 0, "");
          DataTable datos = hab.ListarDisponibles();
          if (datos.Rows.Count > 0)
            {
             Console.WriteLine("Id      Tipo Habitación       Número      Piso       Disponibilidad");
                int i = 0;
          foreach (DataRow ren in datos.Rows)
          {
                 
           Console.WriteLine(ren[0] + "\t" + ren[1] + "\t\t\t" + ren[2] + "\t  " + ren[3] + "\t\t" + ren[4]);
                    i++;
          }
          }
          else
          {
           Console.WriteLine("No hay  habitaciones disponibles.");
          }
        }
        //-------------------FIN MOSTRAR HABITACIONES------------------------------

        //------------------INICIO MOSTRAR ORIGEN----------------------------------
         public void mostrar_origenes()
        {
            DataTable datos = new origen().Listar();

            if (datos.Rows.Count > 0)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("Listado de origenes");
                Console.WriteLine("***********************");

                Console.WriteLine("Id      Nombre");
                Console.WriteLine("------------------");
                int i = 0;
                foreach (DataRow ren in datos.Rows)
                {
                    Console.WriteLine(ren[0] + "\t" + ren[1]);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No hay  origenes registrados.");
            }
        }
        //------------------------FIN MOSTRAR ORIGEN---------------------------

        //-----------------------INICIO MOSTRAR TURNO--------------------------
        public void mostrar_turno()
        {
            DataTable datos = new turno().Listar();

            if (datos.Rows.Count > 0)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("Listado de turnos");
                Console.WriteLine("***********************");

                Console.WriteLine("Id      Nombre");
                Console.WriteLine("------------------");
                int i = 0;
                foreach (DataRow ren in datos.Rows)
                {
                    Console.WriteLine(ren[0] + "\t" + ren[1]);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No hay  turnos registrados.");
            }
        }
        //---------------------FIN MOSTRAR TURNO-----------------------------

        //--------------------INICIO MOSTRAR PACK----------------------------
        public void mostrar_pack()
        {

            DataTable datos = new pack().Listar();

            if (datos.Rows.Count > 0)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("Listado de packs");
                Console.WriteLine("***********************");

                Console.WriteLine("Id      Nombre      Fecha");
                Console.WriteLine("---------------------------------");
                int i = 0;
                foreach (DataRow ren in datos.Rows)
                {
                    Console.WriteLine(ren[0] + "\t" + ren[1] + "      " + ren[2]);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No hay packs registrados.");
            }
        }
        //----------------------FIN MOSTRAR PACK-----------------------------

        //-------------------INICIO MOSTRAR TIPO_HABITACIÓN------------------
        public void mostrar_tipo_habitacion()
        {
            DataTable datos = new tipo_habitacion().Listar();

            if (datos.Rows.Count > 0)
            {
                Console.WriteLine("******************************");
                Console.WriteLine("Listado de tipos de habitacion");
                Console.WriteLine("******************************");

                Console.WriteLine("Id      Nombre");
                Console.WriteLine("------------------");
                int i = 0;
                foreach (DataRow ren in datos.Rows)
                {
                    Console.WriteLine(ren[0] + "\t" + ren[1]);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No hay  turnos registrados.");
            }
        }//-----------------FIN MOSTRAR TIPO_HABITACIÓN----------------------

        //----------------INICIO MOSTRAR STAFF-------------------------------
        public void mostrar_staff()
        {
            DataTable datos = new staff().Listar();

            if (datos.Rows.Count > 0)
            {
                Console.WriteLine("******************************");
                Console.WriteLine("Listado de staff");
                Console.WriteLine("******************************");

                Console.WriteLine("Id      Nombre");
                Console.WriteLine("------------------");
                int i = 0;
                foreach (DataRow ren in datos.Rows)
                {
                    Console.WriteLine(ren[0] + "\t" + ren[1]);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No hay staff registrados.");
            }
        }
        //-----------------FIN MOSTRAR STAFF-----------------------------


        //-----------------INICIO MOSTRAR PROVEEDORES--------------------
        public void mostrar_proveedores()
        {
            DataTable datos = new proveedores().Listar();
            {

                if (datos.Rows.Count > 0)
                {
                    Console.WriteLine("******************************");
                    Console.WriteLine("Listado de proveedores ");
                    Console.WriteLine("******************************");

                    Console.WriteLine("rut      razon social");
                    Console.WriteLine("------------------");
                    int i = 0;
                    foreach (DataRow ren in datos.Rows)
                    {
                        Console.WriteLine(ren[0] + "\t" + ren[1]);
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("No hay proveedores registrados.");
                }
            }
        }
        //-----------------FIN MOSTRAR PROVEEDORES----------------------

        //-----------------INICIO MOSTRAR INSUMO------------------------
        public void mostrar_insumos()
        {
            DataTable datos = new insumo().Listar();
            {

                if (datos.Rows.Count > 0)
                {
                    Console.WriteLine("******************************");
                    Console.WriteLine("Listado de insumos ");
                    Console.WriteLine("******************************");

                    Console.WriteLine("idpack      idproveedor     nombre       cantidad      vencido");
                    Console.WriteLine("------------------");
                    int i = 0;
                    foreach (DataRow ren in datos.Rows)
                    {
                        Console.WriteLine(ren[0] + "\t" + ren[1] + "\t" + ren[2] + "\t" + ren[3] + "\t" + ren[4]);
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("No hay insumos registrados"); 
                }
            }
        }
        //--------------------FIN MOSTRAR INSUMO------------------------
        //----------------INICIO MOSTRAR MANTENCIÓN MES-----------------
        public void mostrar_mantencion_mes()
        {
            DataTable datos = new mantencion_mes().Listar();
            {

                if (datos.Rows.Count > 0)
                {
                    Console.WriteLine("******************************");
                    Console.WriteLine("Listado de mantenciones realizadas ");
                    Console.WriteLine("******************************");

                    Console.WriteLine("fecha      obs");
                    Console.WriteLine("------------------");
                    int i = 0;
                    foreach (DataRow ren in datos.Rows)
                    {
                        Console.WriteLine(ren[0] + "\t" + ren[1]);
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("No hay mantenciones registradas");
                }
            }
        }
        //-----------------FIN MOSTRAR MANTENCIÓN MES-------------------







    }
}
