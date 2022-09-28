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
using System.Runtime.ConstrainedExecution;

namespace Hotel_string
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
                            case 5:
                                menu_proveedores();
                                break;
                            case 6:
                                menu_insumos();
                                break;
                            case 7:
                                menu_pack();
                                break;

                            case 8:

                                menu_turno();
                                break;

                            case 9:
                                menu_origenes();

                                break;  
                            case 10:
                                menu_tipo_habitacion();
                           break;

                            case 11:
                                menu_staff();
                                break;
                            case 12:
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
                    string respuesta;
                    switch (opc)
                    {
                        case 1:
                            respuesta = new Inserciones().crear_rol();
                            Console.WriteLine(respuesta);
                            break;
                        case 2:
                            respuesta = new Eliminaciones().eliminar_rol();
                            Console.WriteLine(respuesta);
                            break;
                        case 3:
                            new Muestras().mostrar_roles();
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

            }//--------------------FIN MENÚ ROLES---------------------------

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
                            respuesta = new Inserciones().crear_origen();
                            Console.WriteLine(respuesta);
                            break;
                        case "2":
                            respuesta = new Eliminaciones().eliminar_origen();
                            Console.WriteLine(respuesta);
                            break;
                        case "3":
                            new Muestras().mostrar_origenes();
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
            }
            //---------------------FIN MENÚ ORIGEN-------------------------

            //---------------------INICIO TURNO----------------------------
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
                            respuesta = new Inserciones().crear_turno();
                            Console.WriteLine(respuesta);
                            break;
                        case "2":
                            respuesta = new Eliminaciones().eliminar_turno();
                            Console.WriteLine(respuesta);
                            break;
                        case "3":
                            new Muestras().mostrar_turno();
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
            }
            //---------------------FIN MENÚ TURNO-----------------------

            //----------------------INICIO PACK-------------------------
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
                            respuesta = new Inserciones().crear_pack();
                            Console.WriteLine(respuesta);
                            break;
                        case "2":
                            respuesta = new Eliminaciones().eliminar_pack();
                            Console.WriteLine(respuesta);
                            break;
                        case "3":
                            new Muestras().mostrar_pack();
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
                    Console.WriteLine("Enter para continuar");
                    Console.ReadLine();
                }
            }
            //----------------------FIN MENÚ PACK------------------------

            //------------------INICIO TIPO_HABITACIÓN-------------------
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
                            respuesta = new Inserciones().crear_tipo_habitacion();
                            Console.WriteLine(respuesta);
                            break;
                        case "2":
                            respuesta = new Eliminaciones().eliminar_tipo_habitacion();
                            Console.WriteLine(respuesta);
                            break;
                        case "3":
                            new Muestras().mostrar_tipo_habitacion();
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
            }
            //--------------------FIN MENÚ TIPO_HABITACIÓN------------------------

            //----------------------INICIO MENÚ STAFF-----------------------------

            static void menu_staff()
            {
                bool fin = true;
                while (fin)
                {
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Menú administración de staff");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("1 Ver staff existentes. ");
                    Console.WriteLine("2 Ingresar nuevo staff. ");
                    Console.WriteLine("3 Eliminar un staff. ");
                    Console.WriteLine("4 Modificar staff. ");
                    Console.WriteLine("0 Salir. ");
                    string opc = Console.ReadLine();
                    string respuesta;
                    switch (opc)
                    {
                        case "1":
                            new Muestras().mostrar_staff();
                            break;
                        case "2":
                            respuesta = new Inserciones().crear_staff();
                            Console.WriteLine(respuesta);
                            break;
                        case "3":
                            respuesta = new Eliminaciones().eliminar_staff();
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
                    Console.WriteLine("Enter para continuar");
                    Console.ReadLine();
                }
            }

            //-----------------------FIN MENÚ STAFF-------------------------------

            //---------------------INICIO MENÚ PROVEEDORES------------------------
            static void menu_proveedores()
            {
                bool fin = true;
                while (fin)
                {
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Menú administración de proveedores");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("1 Ver proveedores existentes. ");
                    Console.WriteLine("2 Ingresar nuevo proveedor. ");
                    Console.WriteLine("3 Eliminar un proveedor. ");
                    Console.WriteLine("4 Modificar proveedor. ");
                    Console.WriteLine("0 Salir. ");
                    string opc = Console.ReadLine();
                    string respuesta;
                    switch (opc)
                    {
                        case "1":
                            new Muestras().mostrar_proveedores();
                            break;
                        case "2":
                            respuesta = new Inserciones().crear_proveedor();
                            Console.WriteLine(respuesta);
                            break;
                        case "3":
                            respuesta = new Eliminaciones().eliminar_proveedor();
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
                    Console.WriteLine("Enter para continuar");
                    Console.ReadLine();
                }
            }
            //-------------------------FIN MENÚ PROVEEDORES----------------

            //------------------------INICIO MENÚ INSUMOS-------------------
            static void menu_insumos()
            {
                bool fin = true;
                while (fin)
                {
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Menú administración de insumos");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("1 Ver proveedores insumos existentes. ");
                    Console.WriteLine("2 Ingresar nuevo insumo. ");
                    Console.WriteLine("3 Eliminar insumo. ");
                    Console.WriteLine("4 Modificar insumo. ");
                    Console.WriteLine("0 Salir. ");
                    string opc = Console.ReadLine();
                    string respuesta;
                    switch (opc)
                    {
                        case "1":
                            new Muestras().mostrar_insumos();
                            break;
                        case "2":
                            respuesta = new Inserciones().crear_insumo();
                            Console.WriteLine(respuesta);
                            break;
                        case "3":
                            respuesta = new Eliminaciones().eliminar_insumo();
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
                    Console.WriteLine("Enter para continuar");
                    Console.ReadLine();
                }
            }
            //-------------------------FIN MENÚ INSUMOS-----------------------

            //----------------------INICIO MENÚ MANTENCIÓN MES----------------
            static void menu_mantencion_mes()
            {
                bool fin = true;
                while (fin)
                {
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Menú administración de mantenciones");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("1 Ver mantenciones registradas. ");
                    Console.WriteLine("2 Ingresar nueva mantención. ");
                    Console.WriteLine("3 Eliminar mantención registrada. ");
                    Console.WriteLine("4 Modificar mantención registrada. ");
                    Console.WriteLine("0 Salir. ");
                    string opc = Console.ReadLine();
                    string respuesta;
                    switch (opc)
                    {
                        case "1":
                            new Muestras().mostrar_mantencion_mes();
                            break;
                        case "2":
                            respuesta = new Inserciones().registrar_mantencion_mes();
                            Console.WriteLine(respuesta);
                            break;
                        case "3":
                            respuesta = new Eliminaciones().eliminar_mantencion();
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
                    Console.WriteLine("Enter para continuar");
                    Console.ReadLine();
                }
            }
            //------------------------FIN MENÚ MANTENCIÓN---------------------



        }//fin main

    }// fin class program
}// fin namespace hotel


