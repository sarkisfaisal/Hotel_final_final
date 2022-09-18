using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_final
{
    internal class tipo_pago
    {
        string descripcion { get; set; }

        public tipo_pago(string descripcion)
        {
            this.descripcion = descripcion;
        }
    }
}
