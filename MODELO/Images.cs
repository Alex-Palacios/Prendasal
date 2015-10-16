using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public enum eTipoImages
    {
        DOCUMENTO = 1,
        ARTICULO
    }


   public class Images
    {

       public int ID;
       public eTipoImages TIPO;
       public string CODIGO;
       public byte[] IMAGEN; 

       public Images()
       {

       }
    }
}
