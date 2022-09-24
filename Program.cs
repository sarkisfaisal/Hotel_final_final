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
                    menu_cliente();
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
                            menu_reservaciones();
                            break;
                        case 5:
                            menu_proveedores();
                            break;
                        case 6:
                            menu_insumos();
                            break;
                        case 7:
                            menu_pack();
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

// ------------------ INICIO MENU CLIENTE ----------------------------
        static void menu_cliente()
        {
            bool fin = true;

            while (fin)
            {

                Console.WriteLine("**************************");
                Console.WriteLine("BIENVENIDO A MENU CLIENTES");
                Console.WriteLine("**************************");

                Console.WriteLine("1 Ingresar cliente");
                Console.WriteLine("2 eliminar cliente");
                Console.WriteLine("2 Listar cliente");
                Console.WriteLine("ingrese una opcion");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        crear_cliente();

                        break;
                    case 2:
                        //eliminar_cliente();
                        break;
                    case 3:
                        mostrar_cliente();
                        break;
                    case 0:
                        fin = false;
                        break;
                    default:
                        Console.WriteLine("No se reconoce la opción elegida");
                        break;
                }


            }

        }//fin menu clientes

// ------------------- FIN MENU CLIENNTES ----------------------------



 // ------------------- INICIO MENU ROLES
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

// -------------------- FIN MENU ROLES ---------------------------

        static void menu_reservaciones()
        {
            bool fin = true;
            while (fin)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("Menú reservaciones");
                Console.WriteLine("***********************");
                Console.WriteLine("1 Realizar una reservación. ");
                Console.WriteLine("2 Cancelar una reservación. ");
                Console.WriteLine("3 Ver reservaciones.");
                Console.WriteLine("0 Salir. ");
                string opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        realizar_reservacion();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "0":
                        fin = false;
                        break;
                    default:
                        Console.WriteLine("No se reconoce la opción elegida");
                        break;
                }
                Console.ReadLine();
            }

        }//fin menú reservaciones


        static void menu_tipo_pago()
        {
            bool fin = true;
            while (fin)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("Menú Tipos de pago");
                Console.WriteLine("***********************");
                Console.WriteLine("1 Crear un tipo de pago. ");
                Console.WriteLine("2 Eliminar tipo de pago. ");
                Console.WriteLine("3 Ver listado de los tipos de pago.");
                Console.WriteLine("0 Salir. ");
                string opc = Console.ReadLine();
                string respuesta;
                switch (opc)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":
                        break;
                    case "0":
                        fin = false;
                        break;
                    default:
                        Console.WriteLine("No se reconoce la opción elegida");
                        break;
                }
                Console.ReadLine();
            }
        }

        static void menu_proveedores()
        {
            bool fin = true;
            while (fin)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("Menú proveedores");
                Console.WriteLine("***********************");
                Console.WriteLine("1 Crear un proveedor. ");
                Console.WriteLine("2 Eliminar proveedor . ");
                Console.WriteLine("3 Modificar proveedor.");
                Console.WriteLine("4 Ver listado de proveedores.");
                Console.WriteLine("0 Salir. ");
                string opc = Console.ReadLine();
                string respuesta;
                switch (opc)
                {
                    case "1":
                        respuesta = crear_proveedor();
                        Console.WriteLine(respuesta);
                        break;
                    case "2":
                        respuesta = eliminar_proveedor();
                        Console.WriteLine(respuesta);
                        break;
                    case "3":
                        break;
                    case "4":
                        mostrar_proveedores();
                        break;
                    case "0":
                        fin = false;
                        break;
                    default:
                        Console.WriteLine("No se reconoce la opción elegida");
                        break;
                }
                Console.ReadLine();
            }
        }

        static void menu_insumos()
        {
            bool fin = true;
            while (fin)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("Menú insumos");
                Console.WriteLine("***********************");
                Console.WriteLine("1 Ingresar un insumo. ");
                Console.WriteLine("2 Eliminar insumo. ");
                Console.WriteLine("3 Ver stock de productos.");
                Console.WriteLine("4 Modificar stock.");
                Console.WriteLine("0 Salir. ");
                string opc = Console.ReadLine();
                string respuesta;
                switch (opc)
                {
                    case "1":
                        respuesta = crear_insumo();
                        Console.WriteLine(respuesta);
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "0":
                        fin = false;
                        break;
                    default:
                        Console.WriteLine("No se reconoce la opción elegida");
                        break;
                }
                Console.ReadLine();
            }
        }

        static void menu_pack()
        {
            bool fin = true;
            while (fin)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("Menú pack");
                Console.WriteLine("***********************");
                Console.WriteLine("1 Crear un pack. ");
                Console.WriteLine("2 Eliminar pack. ");
                Console.WriteLine("3 Ver listado de pack´s.");
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
                        respuesta = Eliminar_pack();
                        Console.WriteLine(respuesta);
                        break;
                    case "3":
                         Mostrar_pack();
                        break;
                    case "4":
                        break;
                    case "0":
                        fin = false;
                        break;
                    default:
                        Console.WriteLine("No se reconoce la opción elegida");
                        break;
                }
                Console.ReadLine();
            }
        }

        //camila=roles
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

        static string crear_rol()
        {
            //se inserta el rol en la base de datos
            Console.WriteLine("Ingrese una descripción para el rol a crear");
            string descripcion = Console.ReadLine();
            rol rol = new rol(descripcion);
            string respuesta = rol.insertar();
            return respuesta;
        }//fin crear rol

        //se elimina el rol en la base de datos
        static string eliminar_rol()
        {
            Console.WriteLine("Ingrese una descripción para el rol a eliminar");
            string descripcion = Console.ReadLine();
            rol rol = new rol(descripcion);
            string respuesta = rol.Eliminar();
            return respuesta;

        }//fin eliminar rol

        // Camila: se traen los tipo_pago de la base de datos y se muestran en pantalla, si no hay registros se retorna un mensaje "Tipo de pago no registrado".

 // -------------------- INICIO MOSTRAR PAGO -------------------------
        /*static void mostrar_tipo_pago()
        {
            tipo_pago tipo_pago = new tipo_pago("");
            DataTable dtt = pago.Listar();
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
        }//fin mostrar pago
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
        }//fin pedir tipo pago */

// ------------------- FIN PEDIR TIPO PAGO --------------------------

        static string eliminar_tipo_pago()
        {
            Console.WriteLine("Ingrese una descripción para el tipo de pago a eliminar");
            string descripcion = Console.ReadLine();
            pago tipo_pago = new pago(descripcion);
            int filas_afectadas = tipo_pago.Eliminar();
            if (filas_afectadas == 0)
            {
             return"No existe el tipo de pago ingresado, no se pudo eliminar";

            }
            else
            {
                return "Registro eliminado exitosamente";
            }

        }//fin tipos de pago

        // Camila: se traen los tipo_habitacion de la base de datos y se muestran en pantalla, si no hay registros se retorna un mensaje "Tipo de pago no registrado".
        static void mostrar_tipo_habitacion()
        {
            pago pago = new pago("");
            DataTable dtt = pago.Listar();
            if (dtt.Rows.Count > 0)
            {
                Console.WriteLine("Id \n Descripción");
                int i = 0;
                foreach (DataRow ren in dtt.Rows)//la variable ren, ahora contendra el valor de cada una de las filas de dtt.
                {
                    Console.WriteLine(ren[0] + "\t" + ren[1]);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No hay tipos de habitación registrados");
            }
            Console.ReadLine();
        }

        //Inicio mostrar cliente
        static void mostrar_cliente()
        {
            //se traen los roles de la base de datos y se muestran en pantalla, si no hay roles muestra el mensaje "no hay roles registrados"
            cliente cliente = new cliente();
            DataTable dtt = cliente.Listar();
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
             Console.WriteLine("No hay rclientes registrados");
            }
            Console.ReadLine();
        }//fin mostrar cliente


        //Inicio crear cliente
        static string crear_cliente()
        {
         //se inserta el rol en la base de datos
            Console.WriteLine("Ingrese una descripción para el rol a crear");
            string descripcion = Console.ReadLine();
            rol rol = new rol(descripcion);
            string respuesta = rol.insertar();
            return respuesta;
        }//fin crear cliente


        //Inicio realizar reservacion
        static string realizar_reservacion()
        {
            int tipo_habitacion = pedir_tipo_habitacion();

            return "";
        }
        //Fin realizar reservacion
        static int pedir_tipo_habitacion()
        {
            bool fin = true;
            while (fin)
            {
                Console.WriteLine("Seleccione un tipo de habitación");
                mostrar_tipo_habitacion();
                int opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                    case 2:
                    case 3:
                        fin = false;
                        return opc;
                    default:
                        Console.WriteLine("No se reconoce la opción ingresada,");
                        Console.WriteLine("por favor intente nuevamente");
                        break;
                }
            }
            return 0;
        }

        //------------Proveedor------------

        //Inicio crear proveedor
        static string crear_proveedor()
        {
            bool fin = true;
            string respuesta="";
            string rut;
            string razonsocial;
            while (fin)
            {
                Console.WriteLine("Ingrese rut de proveedor");
                rut = Console.ReadLine();
                if (rut.Trim().Length != 0)
                {
                    while (fin)
                    {
                        Console.WriteLine("Ingrese razón social de proveedor");
                         razonsocial = Console.ReadLine();
                        if (razonsocial.Trim().Length != 0)
                        {
                            proveedores proveedor = new proveedores(rut, razonsocial);
                            respuesta = proveedor.insertar();
                        }
                        else
                        {
                            Console.WriteLine("No se detectó un valor, intente nuevamente...");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No se detectó un valor, intente nuevamente...");
                }
            }
           return respuesta;
        }//fin crear proveedor

        //Incio eliminar proveedor
        static string eliminar_proveedor()
        {
            Console.WriteLine("Ingrese rut del proveedor a eliminar");
            string rut = Console.ReadLine();
            proveedores p = new proveedores(rut);
            int resultado = p.Eliminar();
            if (resultado == 0)
            {
                return "El cliente no existe, no se puede eliminar";
            }
            else
            {
                return "Cliente eliminado con éxito";
            }
        }//fin eliminar proveedor

        static void mostrar_proveedores()
        {
            proveedores pago = new proveedores("");
            DataTable dtt = pago.Listar();
            if (dtt.Rows.Count > 0)
            {
                Console.WriteLine("Id \n  Rut \n Razón social");
                int i = 0;
                foreach (DataRow ren in dtt.Rows)//la variable ren, ahora contendra el valor de cada una de las filas de dtt.
                {
                    Console.WriteLine(ren[0] + "\t" + ren[1] + "\t" + ren[2]);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No hay tipos de pago registrados");
            }
            Console.ReadLine();
        }//fin mostrar proveedores
        //fin proveedor

        static string crear_insumo()
        {
          return "";
        }
        //pendiente
    //---------Inicio pack---------
    static string crear_pack()
    {
        bool fin = true;
        string respuesta = "";
        while (fin)
        {
            Console.WriteLine("Ingrese descripción del pack");
            string descripcion = Console.ReadLine();
            if (descripcion.Trim().Length!=0)
            {
                pack pack = new pack(descripcion);
                respuesta = pack.insertar();
                fin = false;
                }
                else
                {
                    Console.WriteLine("No se detectó un valor, intente nuevamente...");
                }
        }
        return respuesta;
    }//incio eliminar pack
        static string Eliminar_pack()
        {
            Console.WriteLine("Ingrese la descripción del pack que desea eliminar");
            string descripcion= Console.ReadLine();
            pack p = new pack(descripcion);
            string resultado = p.Eliminar();
            return resultado;
        }//fin eliminar pack

        //inicio mostrar pack
        static void Mostrar_pack()
        {
            pack pack = new pack("");
            DataTable dtt = pack.Listar();
            if (dtt.Rows.Count > 0)
            {
                Console.WriteLine("Descripción \t fecha");
                int i = 0;
                foreach (DataRow ren in dtt.Rows)
                {
                 Console.WriteLine(ren[0] + "\t" + ren[1]);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No hay pack´s registrados");
            }
            Console.ReadLine();
        }//fin listar pack
        //fin de pack




    }//fin class program

}
// fin namespace hotel
