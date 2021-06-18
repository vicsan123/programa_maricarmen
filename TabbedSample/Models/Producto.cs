using System;
using System.Collections.Generic;
using System.Text;

namespace TabbedSample.Models
{
    public class Producto
    {
        public int ID_PRODUCTO { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public bool Flag { get; set; }
        public DateTime FechaVenta { get; set; } ///Dato solo para cuando se agruegue la compra

    }
}
