using System;
using System.Collections.Generic;

namespace AplicacionSeguros.Models;

public partial class Seguro
{
    public int? IdUsuario { get; set; }

    public string? NombreSeguro { get; set; }

    public string? CodigoSeguro { get; set; }

    public int? SumaAsegurada { get; set; }

    public int? Prima { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
