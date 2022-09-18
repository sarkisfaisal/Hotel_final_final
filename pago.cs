using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_final
{
    internal class pago
    {
        string identificacion { get; set; }
        int idtipo_pago { get; set; }
        string fecha { get; set; }
        string moneda { get; set; }
        int total{ get; set; }
        int nota_credito { get; set; }
        int boleta { get; set; }
        int factura { get; set; }

        int voucher { get; set; }

        public pago(string identificacion, int idtipo_pago, string fecha, string moneda, int total, int nota_credito, int boleta, int factura, int voucher)
        {
            this.identificacion = identificacion;
            this.idtipo_pago = idtipo_pago;
            this.fecha = fecha;
            this.moneda = moneda;
            this.total = total;
            this.nota_credito = nota_credito;
            this.boleta = boleta;
            this.factura = factura;
            this.voucher = voucher;
        }
    }// fin class pago
}//fin namespace
