﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

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

            while (contador < 3)
            {
                Console.WriteLine("ingrese usuario ");
                String user = Console.ReadLine();

                Console.WriteLine("ingrese password ");
                string palabra_secreta = Console.ReadLine();

                if ((usuario == user) && (contrasena == palabra_secreta)) 
                { 
                    Console.WriteLine("login correcto");
                    menu();
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
            
            Console.WriteLine("Ingrese una opcion");
            int opcion = int.Parse(Console.ReadLine());



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

        static void menu()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("BIENVENIDO A MENU HOTEL");
            Console.WriteLine("***********************");
            Console.WriteLine("1 ingresar cliente   2 eliminar cliente");
            Console.WriteLine("1 ingresar funcionario   2 eliminar funcionario");
        }
    
    }//fin class program


}// fin namespace hotel