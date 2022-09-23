using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_final
{
    internal class pago
    {
        private string identificacion;
        private int idtipo_pago;
        private string fecha;
        private string moneda;
        private int total;
        private int nota_credito;
        private int boleta;
        private int factura;
        private int voucher;


        public pago(string identificacion, int idtipo_pago, string fecha, string moneda, int total, int nota_credito,int boleta, int factura, int voucher)
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

        }// constructor

        public void SetFecha(string fecha)
        { 
            this.fecha =fecha;
        
        }

        public string GetFecha()
        {
            return fecha;

        }

        public void SetMoneda(string moneda)
        {
            this.moneda = moneda;

        }

        public string GetMoneda()
        {
            return moneda;

        }

        public void SetTotal(int total)
        {
            this.total = total;

        }

        public int GetTotal()
        {
            return total;

        }




    }// fin class pago




}// fin namespace

   

