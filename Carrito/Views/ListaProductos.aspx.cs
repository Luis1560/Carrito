using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Carrito.Controller;
using Carrito.Models.DataSet1TableAdapters;

namespace Carrito.Views
{
    public partial class ListaProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProductos();
            }
        }

        private void CargarProductos()
        {
            productosTableAdapter productosAdapter = new productosTableAdapter();
            DataTable dtproductos = productosAdapter.GetData();
            gvProductos.DataSource = dtproductos;
            gvProductos.DataBind();
        }
    }
}