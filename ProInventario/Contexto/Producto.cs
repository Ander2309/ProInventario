using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProInventario.Contexto;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal? Precio { get; set; }

    public int? Stock { get; set; }

    public int? CategoriaId { get; set; }

    [Browsable(false)]
    public virtual Categoria? Categoria { get; set; }
    [Browsable(false)]
    public virtual ICollection<DetallesInventario> DetallesInventarios { get; set; } = new List<DetallesInventario>();
    [Browsable(false)]
    public virtual ICollection<DetallesReporte> DetallesReportes { get; set; } = new List<DetallesReporte>();
}
