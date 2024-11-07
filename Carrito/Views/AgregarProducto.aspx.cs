using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Carrito.Models.DataSet1TableAdapters;
using Carrito.Controller;
using Carrito;

namespace Carrito.Views
{
    public partial class AgregarProducto : System.Web.UI.Page
    {
        private readonly ControllerP productoController = new ControllerP();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int cantidad = int.Parse(txtCantidad.Text);
            decimal costo = decimal.Parse(txtCosto.Text);
            byte[] imagenBytes = null;

            if (fileImagen.HasFile)
            {
                using (BinaryReader br = new BinaryReader(fileImagen.PostedFile.InputStream))
                {
                    imagenBytes = br.ReadBytes(fileImagen.PostedFile.ContentLength);
                }
            }

            productoController.agregarproducto(nombre, cantidad, costo, imagenBytes);

            Response.Redirect("ListaProductos.aspx");

        }
    }
}