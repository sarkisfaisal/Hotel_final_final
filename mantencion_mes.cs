using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_final
{
    internal class mantencion_mes
    {
        private string mes { get; set; }
        private string obs { get; set; }

        public mantencion_mes(string mes, string obs)
        {
            this.mes = mes;
            this.obs = obs;
        }
    }
}
