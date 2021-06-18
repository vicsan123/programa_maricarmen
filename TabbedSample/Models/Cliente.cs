using System;
using System.Collections.Generic;
using System.Text;

namespace TabbedSample.Models
{
    public class Cliente
    {
        public int ID_CLIENTE { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string  Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Observaciones { get; set; }
        public bool Flag { get; set; }
        public List<Producto> ComprasProductos { get; set; } ///Actualizar fechar, hacer que el precio pueda variar si es necesario en el proceso de compra
        public List<Tratamiento> ComprasTramamientos { get; set; }///Actualizar fechar, hacer que el precio pueda variar si es necesario en el proceso de compra


    }
}
