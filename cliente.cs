using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_final
{
    internal class cliente
    {
        int idpack { get; set; }
        int idstaff { get; set; }
        string nombre { get; set; }
        string apellido { get; set; }
        string nacionalidad { get; set; }
        string fecha_nacimiento { get; set; }
        string estado { get; set; }

        public cliente(int idpack, int idstaff, string nombre, string apellido, string nacionalidad, string fecha_nacimiento, string estado)
        {
            this.idpack = idpack;
            this.idstaff = idstaff;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
            this.fecha_nacimiento = fecha_nacimiento;
            this.estado = estado;
        }
    }//fin class cliente
}//fin namespace
