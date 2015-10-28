using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace PrendaSAL.Reportes
{
    using DDB;
    using MODELO;

    public partial class FotoArticuloForm : Office2007Form
    {
        
        //VARIABLES
        private DBImages dbImages;
        private eOperacion ACCION;
        private string COD_ARTICULO;
        private DataTable pictureList;
        private Images newPicture;
        private Images selectedPicture;
        private Image defaultPicture;

        public FotoArticuloForm(string codigo)
        {
            InitializeComponent(); 
            dbImages = new DBImages();
            COD_ARTICULO = codigo;
            defaultPicture = IMAGEN.BackgroundImage;
        }

        private void FotoArticuloForm_Load(object sender, EventArgs e)
        {
            cargarImagenes();
        }

        
        private void cargarImagenes()
        {
            ARTICULOS.Images.Clear();
            FOTOS.Items.Clear();
            pictureList = dbImages.getFotosArticulo(COD_ARTICULO);
            foreach(DataRow row in pictureList.Rows)
            {
                byte[] img = row.Field<byte[]>("IMAGEN");
                ARTICULOS.Images.Add(HOME.Instance().byteArrayToImage(img));
            }
            for (int i = 0; i < ARTICULOS.Images.Count; i++)
            {
                string numero = (i + 1).ToString().PadLeft(4,'0');
                ListViewItem item = new ListViewItem("FOTO_" + numero , i);
                FOTOS.Items.Add(item);
            }
            if (pictureList.Rows.Count == 0)
            {
                IMAGEN.BackgroundImage = defaultPicture;
                IMAGEN.BackgroundImageLayout = ImageLayout.Center;
            }
        }


        private void cargarImagenSelected()
        {
            selectedPicture = null;
            if (FOTOS.SelectedItems.Count == 1)
            {
                selectedPicture = new Images();
                selectedPicture.ID = pictureList.Rows[FOTOS.SelectedIndices[0]].Field<int>("ID");
                selectedPicture.TIPO = (eTipoImages)pictureList.Rows[FOTOS.SelectedIndices[0]].Field<int>("TIPO");
                selectedPicture.CODIGO = pictureList.Rows[FOTOS.SelectedIndices[0]].Field<string>("CODIGO");
                selectedPicture.IMAGEN = pictureList.Rows[FOTOS.SelectedIndices[0]].Field<byte[]>("IMAGEN");
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            newPicture = new Images();
            newPicture.TIPO = eTipoImages.ARTICULO;
            newPicture.CODIGO = COD_ARTICULO;
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "Bitmap files (*.bmp)|*.bmp|Gif files (*.gif)|*.gif|JGP files (*.jpg)|*.jpg|All (*.*)|*.* |PNG (*.*)|*.png ";
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();
            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                IMAGEN.BackgroundImage = Image.FromFile(dialog.FileName);
                // Stream usado como buffer
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                // Se guarda la imagen en el buffer
                IMAGEN.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                // Se extraen los bytes del buffer para asignarlos como valor para el 
                // parámetro.
                newPicture.IMAGEN = ms.GetBuffer();
                DialogResult guardar = MessageBox.Show("¿Guardar Imagen ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (guardar == DialogResult.Yes)
                {
                    if (dbImages.insertImages(newPicture,HOME.Instance().USUARIO.COD_EMPLEADO))
                    {
                        cargarImagenes();
                    }
                }
                
            }
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (FOTOS.SelectedItems.Count == 1)
            {
                
                DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar la imagen seleccionada ?", "Eliminar Imagen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (eliminar == DialogResult.Yes)
                {
                    cargarImagenSelected();
                    if (dbImages.deleteImages(selectedPicture, HOME.Instance().USUARIO.COD_EMPLEADO))
                    {
                        cargarImagenes();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una imagen a Eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void FOTOS_DoubleClick(object sender, EventArgs e)
        {
            if (FOTOS.SelectedItems.Count == 1)
            {
                cargarImagenSelected();
                if (selectedPicture != null)
                {
                    IMAGEN.BackgroundImage = HOME.Instance().byteArrayToImage(selectedPicture.IMAGEN);
                    IMAGEN.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }


    }
}
