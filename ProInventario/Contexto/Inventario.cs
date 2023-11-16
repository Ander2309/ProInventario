using System;
using System.Collections.Generic;

namespace ProInventario.Contexto;

public partial class Inventario
{
    public int InventarioId { get; set; }

    public DateTime Fecha { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<DetallesInventario> DetallesInventarios { get; set; } = new List<DetallesInventario>();

    public virtual Usuario? User { get; set; }
}
