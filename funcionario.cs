using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_final
{
    internal class funcionario
    {
        int idstaff { get; set; }
        int idrol { get; set; }

        string nombre { get; set; }

        string apellido { get; set; }

        string nacionalidad { get; set; }

        string contrasena { get; set; }

        public funcionario(int idstaff, int idrol, string nombre, string apellido, string nacionalidad, string contrasena)
        {
            this.idstaff = idstaff;
            this.idrol = idrol;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
            this.contrasena = contrasena;
        }


    }
}
