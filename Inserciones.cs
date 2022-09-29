using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_final
{
    internal class Inserciones
    {
      //-------------------------- INICIO CREAR ROL ---------------------------
        public string crear_rol()
        {
                //se inserta el rol en la base de datos
                Console.WriteLine("Ingrese una descripción para el rol a crear");
                string descripcion = Console.ReadLine();
                rol rol = new rol(descripcion);
                string respuesta = rol.insertar();
                return respuesta;
            }
        // ------------------------FIN CREAR ROL--------------------------------

        //----------------------INICIO PEDIR PAGO-------------------------------
        static int pedirtipo_pago()
        {
            bool fin = false;
            while (!false)
            {

                new Muestras().mostrar_tipo_pago();
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
        }
        // ------------------- FIN PEDIR TIPO PAGO ---------------------------

        //------------------INICIO CREAR ORIGEN-------------------------------
        public string crear_origen()
        {
            Console.WriteLine("Ingrese nombre del origen a agregar");
            string origen = Console.ReadLine();
            origen orig = new origen(origen);
            return orig.insertar();
        }
        //----------------FIN CREAR ORIGEN-----------------------------------

        //-------------------INICIO CREAR TURNO------------------------------

        public string crear_turno()
        {
            Console.WriteLine("Ingrese nombre del turno a agregar");
            string tipo = Console.ReadLine();
            turno T = new turno(tipo);
            return T.insertar();
        }
        //--------------------FIN CREAR TURNO--------------------------------

        //-----------------INCIO CREAR PACK----------------------------------
        public string crear_pack()
        {
            Console.WriteLine("Ingrese nombre del pack a agregar");
            string tipo = Console.ReadLine();
            DateOnly fecha = new DateOnly(year: DateTime.Now.Year, month: DateTime.Now.Month, day: DateTime.Now.Day);
            pack P = new pack(tipo, fecha);
            return P.insertar();
        }
        //-----------------FIN CREAR PACK-------------------------------------

        //-------------------INICIO CREAR TIPO_HABITACIÓN---------------------
        public string crear_tipo_habitacion()
        {
            Console.WriteLine("Ingrese nombre de tipo de habitacion a agregar");
            string tipo = Console.ReadLine();
            tipo_habitacion T = new tipo_habitacion(tipo);
            return T.insertar();
        }
        //-------------------FIN CREAR TIPO_HABITACIÓN------------------------

        //-----------------INICIO CREAR STAFF---------------------------------
        public string crear_staff()
        {
            new Muestras().mostrar_turno();
            Console.WriteLine("Ingrese el id del turno correspondiente al staff");
            int idturno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la descripción del staff que desea a agregar");
            string staff = Console.ReadLine();
            staff s = new staff(idturno, staff);
            return s.insertar();
        }
        //-----------------FIN CREAR STAFF-----------------------------------

        //-----------------CREAR O INGRESAR PROVEEDOR------------------------
        public string crear_proveedor()
        {
            Console.WriteLine("Ingrese el rut del proveedor que desea agregar");
            string rut = Console.ReadLine();
            Console.WriteLine("Ingrese la descripción del proveedor que desea a agregar");
            string razon_social = Console.ReadLine();
            proveedores s = new proveedores(rut, razon_social);
            return s.insertar();
        }
        //-----------------FIN CREAR PROVEEDOR------------------------------

        //-------------------INICIO CREAR INSUMO----------------------------
        public string crear_insumo()
        {
            Console.WriteLine("Ingrese el idpack correspondiente para crear");
            int idpack = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el id proveedor correspondiente para crear");
            int id_proveedor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del insumo que desea crear");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de insumos a crear");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese si el insumo se encuentra vencido");
            string vencido = Console.ReadLine();

            insumo insumo = new insumo();
            string respuesta = insumo.insertar();
            return respuesta;
        }
        //-------------------FIN CREAR INSUMO-------------------------------

        //---------------INICIO CREAR MANTENCIÓN MES------------------------
        public string registrar_mantencion_mes()
        {
            Console.WriteLine("Ingrese la fecha en la cual se realizó la mantención que desea registrar");
            string fecha = Console.ReadLine();
            Console.WriteLine("Ingrese su observación sobre mantención que se realizó");
            string obs = Console.ReadLine();
           

            mantencion_mes mantencion = new mantencion_mes();
            string respuesta = mantencion.insertar();
            return respuesta;
        }
        //----------------FIN CREAR MANTENCIÓN MES--------------------------
    }
}
