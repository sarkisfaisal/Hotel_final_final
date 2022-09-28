using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_string
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
        public pago()
        {
    
        }// constructor vacio

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

        public int GetTotal()
        {
            return total;

        }

        public void SetTotal(int total)
        {
            this.total = total;

        }

        public int GetNotaCredito()
        {
            return total;

        }

        public void SetNotaCredito(int nota_credito)
        {
            this.nota_credito = nota_credito;

        }

        public DataTable Listar()
        {
            DataTable dtt;
            conexionbd c = new conexionbd();
            try
            {
                dtt = new DataTable();
                string select = "Select * from pago";
                SqlCommand cmd = new SqlCommand(select, c.conectarbd);
                cmd.CommandType = CommandType.Text;
                c.abrir();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dtt);
                c.cerrar();
                return dtt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtt;
        }//fin linstar
        public string insertar()// terminar 
        {
            conexionbd c = new conexionbd();
            try
            {
                string insert = $"insert into pago values ('')";
                SqlCommand comando = new SqlCommand(insert, c.conectarbd);
                c.abrir();
                comando.ExecuteNonQuery();
                c.cerrar();
                return "Pago ingresado con éxito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }//fin insertar
        public int Eliminar()// terminar 
        {
            conexionbd c = new conexionbd();
            try
            {
                string eliminar = $"delete from tipo_pago = ''";
                SqlCommand comando = new SqlCommand(eliminar, c.conectarbd);
                c.abrir();
                int filas = comando.ExecuteNonQuery();
                c.cerrar();
                return filas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }//fin eliminar





    }// fin class pago




}// fin namespace

   

