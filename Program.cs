using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Data;
using Azure.Core;

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

            while (contador < 3)
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
            Console.WriteLine("BIENVENIDO A MENU HOTEL");
            Console.WriteLine("***********************");
            Console.WriteLine();
            Console.WriteLine();

            static void menu_hotel()
            {
                bool fin = true;

                while (fin)
                {

                    Console.WriteLine("**************************");
                    Console.WriteLine("BIENVENIDO A MENU CLIENTES");
                    Console.WriteLine("**************************");

                    Console.WriteLine("1 Menu Cliente");
                    Console.WriteLine("2 Menu Roles");
                    Console.WriteLine("3 Menu pago");
                    Console.WriteLine("ingrese una opcion");
                    int op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            menu_cliente();
                           
                            break;
                        case 2:
                            menu_roles();
                            break;
                        //case 3:
                            
                            //break;
                        case 0:
                            fin = false;
                            break;
                        default:
                            break;
                    }


                }

            }//fin menu hotel


//SARKIS: SE CREA MENU HOTEL PARA LLAMAR A SUB MENUS CLIENTE Y ROLES


           /* Console.WriteLine("Ingrese una opcion");
            int opcion = int.Parse(Console.ReadLine());
            bool bandera = true;
            (while (bandera)
            {
                switch (opcion)
                {

                    case 1:
                        conexionbd conexion = new conexionbd();
                        Console.WriteLine("estado conexion\n");
                        conexion.abrir();
                        Console.WriteLine("ingrese tipo habitacion");
                        String tipo = Console.ReadLine();
                        tipo_habitacion TH = new tipo_habitacion(tipo);
                        String insertQuery = "INSERT INTO tipo_habitacion(tipo) VALUES('" + TH.GetTipoHabitacion() + "')";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, conexion.conectarbd);
                        insertCommand.ExecuteNonQuery();
                        conexion.cerrar();

                        break;

                    case 2:
                        //conexionbd conexion2 = new conexionbd();
                        //Console.WriteLine("estado conexion\n");
                        //conexion2.abrir();
                        //Console.WriteLine("ingrese tipo habitacion");

                        //tipo_habitacion TH2 = new tipo_habitacion(tipo);

                        String insertQuery2 = "SELECT tipo FROM tipo_habitacion WHERE idtipo_habitacion = 10";
                        SqlCommand selectCommand = new SqlCommand(insertQuery2, conexion2.conectarbd);
                        selectCommand.ExecuteNonQuery();
                        string idtipo_habitacion1 = (string)selectCommand.ExecuteScalar();
                        conexion2.cerrar();
                        break;
                    case 3:
                        menu_roles();
                        break;


                        String SelectTipo_habitacion = "SELECT tipo FROM tipo_habitacion WHERE idtipo_habitacion = 10";
                        SqlCommand selectCommand_Tipo_habitacion = new SqlCommand(SelectTipo_habitacion, conexion2.conectarbd);
                        selectCommand_Tipo_habitacion.ExecuteNonQuery();
                        string tipo_tipo_habitacion = (string)selectCommand_Tipo_habitacion.ExecuteScalar();
                        Console.WriteLine(tipo_tipo_habitacion);
                        conexion2.cerrar();
                        bandera = false;
                        break ;


                    case 0:
                        bandera = false;
                        break;

                }//fin switch


            }//fin while



            conexionbd conexion = new conexionbd();
            Console.WriteLine("estado conexion\n");
            conexion.abrir();
            Console.WriteLine("ingrese tipo habitacion ");
            String TipoHabitacion = Console.ReadLine();
            String insertQuery = "INSERT INTO tipo_habitacion(tipo) VALUES('" + TipoHabitacion + "')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, conexion.conectarbd);
            insertCommand.ExecuteNonQuery();
            conexion.cerrar(); */





        }//fin main

        static void menu_cliente()
        {
            bool bandera = true;

            while (bandera)
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
                        string crear = crear_cliente();
                        Console.WriteLine(crear);
                        break;
                    case 2:
                        eliminar_cliente();
                        break;
                    case 3:
                        mostrar_cliente();
                        break;
                    case 0:
                        fin = false;
                        break;
                    default:
                        break;
                }


            }
            
        }//fin menu clientes

    


        static void menu_roles()
            //camila: se muestran las opciones para administrar roles
        {
            bool fin = true;
            while (fin)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("Menú administración de roles");
                Console.WriteLine("***********************");
                Console.WriteLine("1 Crear un rol. ");
                Console.WriteLine("2 Eliminar un rol. ");
                Console.WriteLine("3 Ver roles existentes. ");
                Console.WriteLine("0 Salir. ");
                string opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        string crear = crear_rol();
                        Console.WriteLine(crear);
                        break;
                    case "2":
                        eliminar_rol(); 
                        break;
                    case "3":
                        mostrar_roles();
                        break;
                    case "0":
                        fin = false;
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
            }

        }

        static void mostrar_roles() {
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

        // Camila: se traen los tipo_pago de la base de datos y se muestran en pantalla, si no está ese tipo de pago se retorna un mensaje "Tipo de pago no registrado".
        static void mostrar_tipo_pago()
        { 
            tipo_pago pago = new tipo_pago("");
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
        }//fin pedir tipo pago

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

        static string crear_cliente()
        {
            //se inserta el rol en la base de datos
            Console.WriteLine("Ingrese una descripción para el rol a crear");
            string descripcion = Console.ReadLine();
            rol rol = new rol(descripcion);
            string respuesta = rol.insertar();
            return respuesta;
        }//fin crear cliente

        //Sarkis: Mostrar clientes


    }//fin class program

}// fin namespace hotel