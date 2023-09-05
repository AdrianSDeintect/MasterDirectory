using Serenity.ComponentModel;
using System;

namespace MasterDirectory.TecnologiasInformacion.Forms;

[FormScript("TecnologiasInformacion.CategoriaTI")]
[BasedOnRow(typeof(CategoriaTIRow), CheckNames = true)]
public class CategoriaTIForm
{
    [Tab("General")]
    public string LocalSap { get; set; }
    public string Nse { get; set; }
    public string Cluster { get; set; }
    public string Brick { get; set; }

    [Tab("GEO")]
    public string UsuarioGeo { get; set; }
    public string Emaillocal { get; set; }
    public string Extension { get; set; }
    public string Telefono { get; set; }
    
    //public DateTime DtRegistro { get; set; }
}