using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_final
{
    class Program
    {

        static void Main(string[] args)

            //Login

            
        {



            Console.WriteLine("***************************");
            Console.WriteLine("Bienvenido al area de login");
            Console.WriteLine("***************************");


            string usuario = "admin";
            string contrasena = "123";

           int contador = 1;

            while (contador <= 3)
            {
                Console.WriteLine("ingrese usuario ");
                String user = Console.ReadLine();

                Console.WriteLine("ingrese password ");
                string palabra_secreta = Console.ReadLine();

                if ((usuario == user) && (contrasena == palabra_secreta)) 
                { 
                    Console.WriteLine("login correcto");
                    //menu();
                    break;
                } 
                else
                { 
                    
                    Console.WriteLine("Login incorrecto");
                    contador++;
                }

            }

            int opcion =0;

            while (opcion != 2)
            { 
                
            
            
            
            }
           
            //conexionbd conexion = new conexionbd();
            //Console.WriteLine("estado conexion\n");
            //conexion.abrir();
            //Console.WriteLine("ingrese tipo habitacion ");
            //String TipoHabitacion = Console.ReadLine();
            //String insertQuery = "INSERT INTO tipo_habitacion(tipo) VALUES('" + TipoHabitacion + "')";
            //SqlCommand insertCommand = new SqlCommand(insertQuery, conexion.conectarbd);
            //insertCommand.ExecuteNonQuery();
            //conexion.cerrar();
           
            
            
        
        
        }//fin main
    
    }//fin class program


}// fin namespace hotel