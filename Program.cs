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
      //----------------INICIO PROGRAMA-------------------
        static void Main(string[] args)
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Bienvenido al area de login");
            Console.WriteLine("***************************");

            //string usuario = "admin";
            //string contrasena = "123";

            int contador = 1;

            //---------------INICIO LOGIN-------------------------
            while (contador < 4)
            {
                //Console.WriteLine("ingrese usuario ");
                //String user = Console.ReadLine();

                //Console.WriteLine("ingrese password ");
                //string palabra_secreta = Console.ReadLine();

                //if ((usuario == user) && (contrasena == palabra_secreta))
                //{
                //    Console.WriteLine("login correcto");
                //    menu_hotel();
                //    break;
                //}
                //else
                //{
                //    Console.WriteLine("");
                //    Console.WriteLine("Login incorrecto");
                //    contador++;
                //    Console.WriteLine(contador);
                //}

               //----------------INICIO MENU HOTEL----------------------

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
                        //Console.WriteLine("8 Menú staff");
                        Console.WriteLine("8 Menú turno");
                        Console.WriteLine("9 Menú pendiente");
                        Console.WriteLine("10 Menú tipo habitacion");
                        Console.WriteLine("11 salir");
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
                                //menu_pago();
                            //break;
                            //case 4:
                                //menu_reservaciones();
                                //break;
                            //case 5:
                                //menu_proveedores();
                               // break;
                           // case 6:
                                //menu_insumos();
                             //   break;
                            case 7:
                                menu_pack();
                                break;

                            case 8:

                                menu_turno();
                                break;

                            case 9:

                                break;  
                               
                            case 10:
                                menu_tipo_habitacion();
                           break;

                            case 11:
                                fin = true;
                                break;
                            default:
                                break;
                        }

                        if (op == 11)
                        {
                            fin = true;
                            Console.WriteLine("hasta luego");

                        }
                    }

                }//-------------FIN MENU HOTEL-------------------------


            }//fin main

            //------------------INICIO MENU ROLES-----------------------
            static void menu_roles()
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

                            break;
                        default:
                            Console.WriteLine("No se reconoce la opción elegida");
                            break;
                    }

                    if (opc == 0)
                    {
                        fin = true;
                        Console.WriteLine("Salio a menu principal");
                    }
                    Console.WriteLine("presione enter");
                    Console.ReadLine();
                }

            }//---------------FIN MENU ROLES----------------------

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
            }
            // -------------------- FIN MOSTRAR ROLES ---------------------------


            //-------------------------- INICIO CREAR ROL -----------------------
            static string crear_rol()
            {
                //se inserta el rol en la base de datos
                Console.WriteLine("Ingrese una descripción para el rol a crear");
                string descripcion = Console.ReadLine();
                rol rol = new rol(descripcion);
                string respuesta = rol.insertar();
                return respuesta;
            }//fin crear rol

            // --------------- FIN CREAR ROL --------------------

            //--------------- INICIO ELIMINAR ROL ----------------------
            static string eliminar_rol()
            {
                Console.WriteLine("Ingrese una descripción para el rol a eliminar");
                string descripcion = Console.ReadLine();
                rol rol = new rol(descripcion);
                string respuesta = rol.Eliminar();
                return respuesta;

            }//fin eliminar rol

            //--------------------------FIN ELIMINAR ROL ---------------------

            // Camila: se traen los tipo_pago de la base de datos y se muestran en pantalla, si no hay registros se retorna un mensaje "Tipo de pago no registrado".

            // -------------------- INICIO MOSTRAR PAGO -------------------------
            /*static void mostrar_tipo_pago()
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
            }//fin mostrar tipo pago

    //---------------------- FIN MOSTRAR TIPO PAGO ------------------
             //Camila: aquí realize un método para pedir el tipo de pago que se va a realizar.
            public int pedirtipo_pago()
            {
                bool fin = false;
                while (!false)
                {

                    mostrar_tipo_pago();
                    string respuesta = Console.ReadLine();
                    switch (respuesta)
                    {
                        case "1":
                        case "2":
                        case "3":
                            fin = true;
                            return Convert.ToInt32(respuesta);
                            break;
                        default:
                            Console.WriteLine("No se reconoce la opción ingresada, intente nuevamente");
                            Console.ReadLine();
                            break;
                    }

                }
            }//fin pedir tipo pago 

    // ------------------- FIN PEDIR TIPO PAGO --------------------------

         /*   static string eliminar_tipo_pago()
            {
                Console.WriteLine("Ingrese una descripción para el tipo de pago a eliminar");
                string descripcion = Console.ReadLine();
                pago tipo_pago = new pago();
                int filas_afectadas = tipo_pago.Eliminar();
                if (filas_afectadas == 0)
                {
                 return"No existe el tipo de pago ingresado, no se pudo eliminar";

                }
                else
                {
                    return "Registro eliminado exitosamente";
                }

            }//fin tipos de pago */

            // Camila: se traen los tipo_habitacion de la base de datos y se muestran en pantalla, si no hay registros se retorna un mensaje "Tipo de pago no registrado".

            //---------Inicio Habitaciones---------

            void mostrar_habitaciones_disponibles()
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

            // -------------------- INICIO ORIGENES-------------------------
            static void menu_origenes()
            {
                bool fin = true;
                while (fin)
                {
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Menú administración de origenes");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("1 Crear un origen. ");
                    Console.WriteLine("2 Eliminar un origen. ");
                    Console.WriteLine("3 Ver origenes existentes.");
                    Console.WriteLine("4 Modificar origen.");
                    Console.WriteLine("0 Salir. ");
                    string opc = Console.ReadLine();
                    string respuesta;
                    switch (opc)
                    {
                        case "1":
                            respuesta = crear_origen();
                            Console.WriteLine(respuesta);
                            break;
                        case "2":
                            respuesta = eliminar_origen();
                            Console.WriteLine(respuesta);
                            break;
                        case "3":
                            mostrar_origenes();
                            Console.ReadLine();
                            break;
                        case "4":
                            break;
                        case "0":
                            fin = false;
                            break;
                        default:
                            Console.WriteLine("No se reconoce la opción ingresada, intente nuevamente...");
                            Console.ReadLine();
                            break;
                    }
                }
            }// fin menu origenges

            static string crear_origen()
            {
                Console.WriteLine("Ingrese nombre del origen a agregar");
                string origen = Console.ReadLine();
                origen orig = new origen(origen);
                return orig.insertar();
            }//fin crear origen

            static string eliminar_origen()
            {
                Console.WriteLine("Ingrese el nombre del origen a eliminar");
                string eliminado = Console.ReadLine();
                origen origen = new origen(eliminado);
                return origen.Eliminar();
            }//fin eliminar origen

            static void mostrar_origenes()
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
            }//fin mostrar origen

            static void menu_turno()
            {
                bool fin = true;
                while (fin)
                {
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Menú administración de turnos");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("1 Crear un turno. ");
                    Console.WriteLine("2 Eliminar un turno. ");
                    Console.WriteLine("3 Ver turnos existentes.");
                    Console.WriteLine("4 Modificar turno.");
                    Console.WriteLine("0 Salir. ");
                    string opc = Console.ReadLine();
                    string respuesta;
                    switch (opc)
                    {
                        case "1":
                            respuesta = crear_turno();
                            Console.WriteLine(respuesta);
                            break;
                        case "2":
                            respuesta = eliminar_turno();
                            Console.WriteLine(respuesta);
                            break;
                        case "3":
                            mostrar_turno();
                            Console.ReadLine();
                            break;
                        case "4":
                            break;
                        case "0":
                            fin = false;
                            break;
                        default:
                            Console.WriteLine("No se reconoce la opción ingresada, intente nuevamente...");
                            Console.ReadLine();
                            break;
                    }
                }
            }// fin menu turno

            static string crear_turno()
            {
                Console.WriteLine("Ingrese nombre del turno a agregar");
                string tipo = Console.ReadLine();
                turno T = new turno(tipo);
                return T.insertar();
            }//fin crear turno

            static string eliminar_turno()
            {
                Console.WriteLine("Ingrese el nombre del turno a eliminar");
                string eliminado = Console.ReadLine();

                turno T = new turno(eliminado);
                return T.Eliminar();
            }//fin eliminar turno

            static void mostrar_turno()
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
            }//fin mostrar turno

            static void menu_pack()
            {
                bool fin = true;
                while (fin)
                {
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Menú administración de packs");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("1 Crear un pack. ");
                    Console.WriteLine("2 Eliminar un pack. ");
                    Console.WriteLine("3 Ver packs existentes.");
                    Console.WriteLine("4 Modificar pack.");
                    Console.WriteLine("0 Salir. ");
                    string opc = Console.ReadLine();
                    string respuesta;
                    switch (opc)
                    {
                        case "1":
                            respuesta = crear_pack();
                            Console.WriteLine(respuesta);
                            break;
                        case "2":
                            respuesta = eliminar_pack();
                            Console.WriteLine(respuesta);
                            break;
                        case "3":
                            mostrar_pack();
                            Console.ReadLine();
                            break;
                        case "4":
                            break;
                        case "0":
                            fin = false;
                            break;
                        default:
                            Console.WriteLine("No se reconoce la opción ingresada, intente nuevamente...");
                            Console.ReadLine();
                            break;
                    }
                }
            }// fin menu turno

            static string crear_pack()
            {
                Console.WriteLine("Ingrese nombre del pack a agregar");
                string tipo = Console.ReadLine(); 
                DateOnly fecha = new DateOnly(year: DateTime.Now.Year, month: DateTime.Now.Month, day: DateTime.Now.Day);
                pack P = new pack(tipo,fecha);
                return P.insertar();
                menu_pack();
            }//fin crear turno

            static string eliminar_pack()
            {
                mostrar_pack();
                Console.WriteLine("Ingrese el nombre del pack a eliminar");
                string eliminado = Console.ReadLine();
                DateOnly fecha = new DateOnly(year: DateTime.Now.Year, month: DateTime.Now.Month, day: DateTime.Now.Day);
                pack P = new pack(eliminado,fecha);
                return P.Eliminar();
                
            }//fin eliminar turno

            static void mostrar_pack()
            {
                
                DataTable datos = new pack().Listar();

                if (datos.Rows.Count > 0)
                {
                    Console.WriteLine("***********************");
                    Console.WriteLine("Listado de packs");
                    Console.WriteLine("***********************");

                    Console.WriteLine("Id      Nombre ");
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
                    Console.WriteLine("No hay packs registrados.");
                }
            }//fin mostrar pack

           
            static void menu_tipo_habitacion()
            {
                bool fin = true;
                while (fin)
                {
                    Console.WriteLine("*****************************************");
                    Console.WriteLine("Menú administración de tipo de habitacion");
                    Console.WriteLine("*****************************************");
                    Console.WriteLine("1 Crear un tipo de habitacion. ");
                    Console.WriteLine("2 Eliminar un tipo de habitacion. ");
                    Console.WriteLine("3 Ver tipos de habitaciones existentes.");
                    Console.WriteLine("4 Modificar tipos de habitaciones.");
                    Console.WriteLine("0 Salir. ");
                    string opc = Console.ReadLine();
                    string respuesta;
                    switch (opc)
                    {
                        case "1":
                            respuesta = crear_turno();
                            Console.WriteLine(respuesta);
                            break;
                        case "2":
                            respuesta = eliminar_turno();
                            Console.WriteLine(respuesta);
                            break;
                        case "3":
                            mostrar_turno();
                            Console.ReadLine();
                            break;
                        case "4":
                            break;
                        case "0":
                            fin = false;
                            break;
                        default:
                            Console.WriteLine("No se reconoce la opción ingresada, intente nuevamente...");
                            Console.ReadLine();
                            break;
                    }
                }
            }// fin menu turno

            static string crear_tipo_habitacion()
            {
                Console.WriteLine("Ingrese nombre del tipo de habitacion a agregar");
                string tipo = Console.ReadLine();
                tipo_habitacion T = new tipo_habitacion(tipo);
                return T.insertar();
            }//fin crear turno

            static string eliminar_tipo_habitacion()
            {
                Console.WriteLine("Ingrese el nombre del turno a eliminar");
                string eliminado = Console.ReadLine();

                tipo_habitacion T = new tipo_habitacion(eliminado);
                return T.Eliminar();
            }//fin eliminar turno

            static void mostrar_tipo_habitacion()
            {
                DataTable datos = new turno().Listar();

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
            }//fin mostrar turno

        }//fin main

    }// fin class program
}// fin namespace hotel
