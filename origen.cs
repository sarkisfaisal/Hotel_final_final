using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_final
{
    internal class origen
    {
        string nombre { get; set;}

        public origen(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
