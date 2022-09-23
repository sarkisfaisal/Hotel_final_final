using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_final
{
    internal class staff
    {
        private int idturno; 
        string descripcion { get;set; }

        public staff(int idturno, string descripcion)
        { 
            this.idturno = idturno;
            this.descripcion = descripcion;
        
        }
    }
}
