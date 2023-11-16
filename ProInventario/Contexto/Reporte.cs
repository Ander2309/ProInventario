using System;
using System.Collections.Generic;

namespace ProInventario.Contexto;

public partial class Reporte
{
    public int ReporteId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int? UsuarioId { get; set; }

    public virtual ICollection<DetallesReporte> DetallesReportes { get; set; } = new List<DetallesReporte>();

    public virtual Usuario? Usuario { get; set; }
}
