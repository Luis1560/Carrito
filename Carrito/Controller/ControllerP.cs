using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Carrito.Models.DataSet1TableAdapters;

namespace Carrito.Controller
{
    public class ControllerP
    {
        private readonly productosTableAdapter productosadapter;

        public ControllerP()
        {
            productosadapter = new productosTableAdapter();
        }
        public void agregarproducto(string nombre, int cantidad, decimal costo, byte[] imagenBytes)
        {
            try
            {
                productosadapter.Insert(nombre, cantidad, costo, imagenBytes);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el producto: " + ex.Message);
            }
        }
        public DataTable ObtenerProductos()
        {
            try
            {
                return productosadapter.GetData();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener la lista de productos: " + ex.Message);
            }
        }
    }
}