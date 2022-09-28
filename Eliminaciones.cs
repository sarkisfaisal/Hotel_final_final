using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_string
{
    internal class Eliminaciones
    {

        //--------------- INICIO ELIMINAR ROL ----------------------
        public string eliminar_rol()
        {
            Console.WriteLine("Ingrese una descripción para el rol a eliminar");
            string descripcion = Console.ReadLine();
            rol rol = new rol(descripcion);
            string respuesta = rol.Eliminar();
            return respuesta;
        }
        //--------------------------FIN ELIMINAR ROL ---------------------

        //--------------------INICIO ELIMINAR TIPO PAGO----------------------
        public string eliminar_tipo_pago()
        {
            Console.WriteLine("Ingrese una descripción para el tipo de pago a eliminar");
            string descripcion = Console.ReadLine();
            pago tipo_pago = new pago();
            int filas_afectadas = tipo_pago.Eliminar();
            if (filas_afectadas == 0)
            {
                return "No existe el tipo de pago ingresado, no se pudo eliminar";

            }
            else
            {
                return "Registro eliminado exitosamente";
            }
        }
        //----------------FIN ELIMINAR TIPO PAGO-----------------

        //---------------INICIO ELIMINAR ORIGEN--------------
        public string eliminar_origen()
        {
            Console.WriteLine("Ingrese el nombre del origen a eliminar");
            string eliminado = Console.ReadLine();
            origen origen = new origen(eliminado);
            return origen.Eliminar();
        }
        //-------------FIN ELIMINAR ORIGEN-------------------


        //------------------INICIO ELIMINAR TURNO------------------------

        public string eliminar_turno()
        {
            Console.WriteLine("Ingrese el nombre del turno a eliminar");
            string eliminado = Console.ReadLine();

            turno T = new turno(eliminado);
            return T.Eliminar();
        }
        //----------------FIN ELIMINAR TURNO-------------------------

        //-----------------INICIO ELIMINAR PACK------------------------
        public string eliminar_pack()
        {
            //mostrar_pack();
            Console.WriteLine("Ingrese el nombre del pack a eliminar");
            string eliminado = Console.ReadLine();
            Console.WriteLine("Ingrese el fecha del pack a eliminar");
            string fecha = Console.ReadLine();
            //DateOnly fecha = new DateOnly(year: DateTime.Now.Year, month: DateTime.Now.Month, day: DateTime.Now.Day);
            pack P = new pack(eliminado, fecha);
            return P.Eliminar();

        }
        //----------------FIN ELIMINAR PACK-------------------------

        //------------------INICIO ELIMINAR TIPO_HABITACIÓN-------------------
        public string eliminar_tipo_habitacion()
        {
            Console.WriteLine("Ingrese nombre de tipo de habitacion a eliminar");
            string eliminado = Console.ReadLine();

            tipo_habitacion T = new tipo_habitacion(eliminado);
            return T.Eliminar();
        }
        //----------------FIN ELIMINAR TIPO_HABITACIÓN-----------------


        //-----------------INICIO ELIMINAR STAFF---------------------

        public string eliminar_staff()
        {
            Console.WriteLine("Ingrese la descripción del staff que desea eliminar");
            string eliminado = Console.ReadLine();

            staff s = new staff(0, eliminado);
            return s.Eliminar();
        }

        //-----------------FIN ELIMINAR STAFF------------------------

        //-----------------INICIO ELIMINAR PROVEEDOR----------------
        public string eliminar_proveedor()
        {
            Console.WriteLine("Ingrese el rut del proveedor que desea eliminar");
            string rut = Console.ReadLine();
            Console.WriteLine("Ingrese la razon social del proveedor que desea eliminar");
            string razon_social = Console.ReadLine();

            proveedores p = new proveedores(rut, razon_social);
            int filas = p.Eliminar();
            if (filas == 0)
            {
                return "No se puede eliminar, los datos ingresados no existen";
            }
            else
            {
                return "Proveedor eliminado exitosamente";
            }
        }
        //----------------FIN ELIMINAR PROVEEDOR---------------------

        //-----------------INICIO ELIMINAR INSUMO--------------------
        public string eliminar_insumo()
        {
            Console.WriteLine("Ingrese el nombre del insumo que desea eliminar");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de insumos a crear");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            insumo i = new insumo();
            int filas = i.Eliminar();
            if (filas == 0)
            {
                return "No se puede eliminar, los datos ingresados no existen";
            }
            else
            {
                return "Insumo eliminado exitosamente";
            }
        }
        //-----------------FIN ELIMINAR INSUMO-----------------------



    }
}
