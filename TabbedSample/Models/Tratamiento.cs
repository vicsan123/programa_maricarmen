using System;
using System.Collections.Generic;
using System.Text;

namespace TabbedSample.Models
{
    public class Tratamiento
    {
        public int ID_TRATAMIENTO { get; set; }
        public string NombreTratamiento { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaTratamiento { get; set; }
    }
}
