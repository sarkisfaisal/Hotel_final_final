using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Data;
using Azure.Core;
using System.Reflection.PortableExecutable;
using Microsoft.Identity.Client;

namespace Hotel_final


{
    class Program
    {

        static void Main(string[] args)

        //Login//


        {



            Console.WriteLine("***************************");
            Console.WriteLine("Bienvenido al area de login");
            Console.WriteLine("***************************");




            string usuario = "admin";
            string contrasena = "123";

            int contador = 1;

            while (contador < 4)
            {
                Console.WriteLine("ingrese usuario ");
                String user = Console.ReadLine();

                Console.WriteLine("ingrese password ");
                string palabra_secreta = Console.ReadLine();

                if ((usuario == user) && (contrasena == palabra_secreta))
                {
                    Console.WriteLine("login correcto");
                   // menu_cliente();
                    break;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Login incorrecto");
                    contador++;
                    Console.WriteLine(contador);
                }

            }

            Console.WriteLine("***********************");
            Console.WriteLine("BIENVENIDO A HOTEL");
            Console.WriteLine("***********************");
            Console.WriteLine();
            Console.WriteLine();

            menu_hotel();

            static void menu_hotel()
            {
                bool fin = false;

                while (!fin)
                {

                    Console.WriteLine("**************************");
                    Console.WriteLine("BIENVENIDO A MENÚ PRINCIPAL");
                    Console.WriteLine("**************************");

                    Console.WriteLine("1 Menú cliente");
                    Console.WriteLine("2 Menú roles");
                    Console.WriteLine("3 Menú pago");
                    Console.WriteLine("4 Menú reservaciones");
                    Console.WriteLine("5 Menú proveedores");
                    Console.WriteLine("6 Menú insumos");
                    Console.WriteLine("7 Menú pack");
                    Console.WriteLine("8 Menú staff");
                    Console.WriteLine("Ingrese una opción");
                    int op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        //case 1:
                            //menu_cliente();
                            //break;
                        case 2:
                            menu_roles();
                            break;
                        //case 3
                        //break;
                        case 4:
                            //menu_reservaciones();
                            //break;
                        case 5:
                            //menu_proveedores();
                            //break;
                        case 6:
                            //menu_insumos();
                            //break;
                        case 7:
                            //menu_pack();
                            break;
                        //case 8:
                            
                            //menu_staff();
                            //break;
                        case 0:
                            fin = true;
                            break;
                        default:
                            break;
                    }


                }

            }//fin menu hotel


        }//fin main

    // ------------- SE INICIA MENU ROLES ----------------------
        static void menu_roles()
        //camila: se muestran las opciones para administrar roles
        {
            bool fin = false;
            while (!fin)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("Menú administración de roles");
                Console.WriteLine("***********************");
                Console.WriteLine("1 Crear un rol. ");
                Console.WriteLine("2 Eliminar un rol. ");
                Console.WriteLine("3 Ver roles existentes. ");
                Console.WriteLine("0 Salir. ");
                int opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        string crear = crear_rol();
                        Console.WriteLine(crear);
                        break;
                    case 2:
                        eliminar_rol();
                        break;
                    case 3:
                        mostrar_roles();
                        break;
                    case 0:
                        fin = true;
                        break;
                    default:
                        Console.WriteLine("No se reconoce la opción elegida");
                        break;
                }
                Console.ReadLine();
            }

        }//fin menú roles


    //------------- FIN MENU ROLES ---------------------------

        
     
     // --------------- INICIO MOSTRAR ROLES ---------------
        static void mostrar_roles()
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
        }//fin mostrar roles

        // ----------------- FIN MOSTRAR ROLES ------------------

        //-------- INICIO CREAR ROL ---------------------

        static string crear_rol()
        {
            //se inserta el rol en la base de datos
            Console.WriteLine("Ingrese una descripción para el rol a crear");
            string descripcion = Console.ReadLine();
            rol rol = new rol(descripcion);
            string respuesta = rol.insertar();
            return respuesta;
        }//fin crear rol

        // --------------- FIN CREAR ROL ---------------

  

    // ------- INICIO ELIMINAR ROL ------------------------
        static string eliminar_rol()
        {
            Console.WriteLine("Ingrese una descripción para el rol a eliminar");
            string descripcion = Console.ReadLine();
            rol rol = new rol(descripcion);
            string respuesta = rol.Eliminar();
            return respuesta;

        }//fin eliminar rol
         // -------------------- FIN ELIMINAR ROL ---------------------------

 

        

          
    }//fin class program

}
// fin namespace hotel