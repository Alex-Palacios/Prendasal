using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    using MODELO;
    using DDB;
    using System.Data;

    public class ImagesController
    {
        private DBImages db;

        public ImagesController()
        {
            db = new DBImages();
        }





        public DataTable getDocDigitCliente(string cliente)
        {
            return db.getDocCliente(cliente);
        }



        public DataTable getFotosArticulo(string inventario)
        {
            return db.getFotosArticulo(inventario);
        }






        public bool guardarImagen(Images DOC,string empleado)
        {
            try
            {
                db.insertImages(DOC, empleado);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool eliminarImagen(Images DOC, string empleado)
        {
            try
            {
                db.deleteImages(DOC,empleado);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
