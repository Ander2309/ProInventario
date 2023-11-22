using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProInventario.Contexto;

public partial class Categoria
{
    public int CategoriaId { get; set; }

    public string Nombre { get; set; } = null!;

    [Browsable(false)]
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
