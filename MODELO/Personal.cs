using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public enum eTipoPersonal
    {
        EMPLEADO = 1,
        SOCIO = 2
    }


    public enum ePuesto
    {
        GERENTE = 1,
        TECNICO,
        CONTADOR,
        AUXILIAR,
        SUPERVISOR,
        ASESOR,
        VENDEDOR,
        BODEGA,
    }



    public class Personal
    {
        public string CODEMP;
        public string NOMBRE;
        public DateTime FECHA_NAC;
        public string DUI;
        public string NIT;
        public string ISSS;
        public string AFP;
        public string TEL;
        public string EMAIL;
        public eTipoPersonal TIPO;
        public string PUESTO;
        public bool EN_PLANILLA;
        public bool ACTIVO;
        public DateTime FECHA_INICIO;

        public Personal()
        {
            
        }

    }
}
