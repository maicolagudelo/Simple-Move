using System;
using System.Collections.Generic;

namespace SimpleMove.Models.DB
{
    public partial class Ejmplo
    {
        public string Correo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public int? Costo { get; set; }
        public string? Contactos { get; set; }
    }
}
