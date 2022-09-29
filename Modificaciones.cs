using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_final
{
    internal class Modificaciones
    {
        public string modificar_rol() {
            bool fin = true;
            string respuestaFinal =  "Ha ocurrido un error intente nuevamente.";
            while (fin)
            {
                new Muestras().mostrar_roles();
                Console.WriteLine("Ingrese el id del rol a modificar");
                string idrol = Console.ReadLine();
                DataTable datos = new rol().TraerFila(idrol);
                if (datos.Rows.Count == 0)
                {
                    Console.WriteLine("No se encontró un rol con ese Id");
                    Console.WriteLine("Pulse cualquier tecla para continuar");
                    Console.WriteLine("2. Salir");
                    string opcion = Console.ReadLine();
                    if (opcion == "2")
                    {
                        fin = false;
                        respuestaFinal = "";
                    }
                }
                else
                {
                    string descripcionAntigua = datos.Rows[1].ToString();
                    Console.WriteLine("Ingrese una nueva descripción para el rol que desea modificar");
                    string descripcionNueva = Console.ReadLine();
                    respuestaFinal = new rol(descripcionNueva).modificar(descripcionAntigua);
                }

            }
            return respuestaFinal;
        }
    }
}