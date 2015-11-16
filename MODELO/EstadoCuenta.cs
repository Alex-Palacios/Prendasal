using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    using System.Data;

    public class EstadoCuenta
    {
        public Cliente CLIENTE;
        public int VIGENTES;
        public int VENCIDOS;
        public int CANCELADOS;
        public decimal PRESTAMOS;
        public decimal ABONOS;
        public decimal SALDOS;

        public DataTable MOVIMIENTOS;

        public EstadoCuenta()
        {
            //DATOS POR DEFECTO
            CLIENTE = new Cliente();
            MOVIMIENTOS = new DataTable();
            MOVIMIENTOS.Columns.Add("COD_TRANS").DataType = System.Type.GetType("System.String");
            MOVIMIENTOS.Columns.Add("FECHA").DataType = System.Type.GetType("System.DateTime");
            MOVIMIENTOS.Columns.Add("CONTRATO").DataType = System.Type.GetType("System.String");
            MOVIMIENTOS.Columns.Add("ARTICULO").DataType = System.Type.GetType("System.String");
            MOVIMIENTOS.Columns.Add("PRESTAMO").DataType = System.Type.GetType("System.Decimal");
            MOVIMIENTOS.Columns.Add("ESTADO_CONTRATO").DataType = System.Type.GetType("System.String");
            MOVIMIENTOS.Columns.Add("ABONO").DataType = System.Type.GetType("System.Decimal");
            MOVIMIENTOS.Columns.Add("SALDO").DataType = System.Type.GetType("System.Decimal");
            MOVIMIENTOS.Columns.Add("INTERES").DataType = System.Type.GetType("System.Decimal");
            MOVIMIENTOS.Columns.Add("DIAS").DataType = System.Type.GetType("System.Int64");
        }




        public EstadoCuenta Copy()
        {
            EstadoCuenta copy = (EstadoCuenta)this.MemberwiseClone();
            return copy;
        }

    }
}
