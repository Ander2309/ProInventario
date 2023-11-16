using System;
using System.Collections.Generic;

namespace ProInventario.Contexto;

public partial class DetallesInventario
{
    public int DetalleId { get; set; }

    public int? InventarioId { get; set; }

    public int? ProductoId { get; set; }

    public int? Cantidad { get; set; }

    public virtual Inventario? Inventario { get; set; }

    public virtual Producto? Producto { get; set; }
}
