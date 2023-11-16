using System;
using System.Collections.Generic;

namespace ProInventario.Contexto;

public partial class DetallesReporte
{
    public int DetalleReporteId { get; set; }

    public int? ReporteId { get; set; }

    public int? ProductoId { get; set; }

    public int? Cantidad { get; set; }

    public virtual Producto? Producto { get; set; }

    public virtual Reporte? Reporte { get; set; }
}
