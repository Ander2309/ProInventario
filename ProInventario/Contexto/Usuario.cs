using System;
using System.Collections.Generic;

namespace ProInventario.Contexto;

public partial class Usuario
{
    public int UserId { get; set; }

    public string Nombre { get; set; } = null!;

    public string CorreoElectronico { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public string Rol { get; set; } = null!;

    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();

    public virtual ICollection<Reporte> Reportes { get; set; } = new List<Reporte>();
}
