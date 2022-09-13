using System;
using System.Collections.Generic;

namespace MusicStoreMVC.Models
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string Precio { get; set; } = null!;
        public long Activo { get; set; }
    }
}
