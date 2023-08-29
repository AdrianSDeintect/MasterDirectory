using Serenity.ComponentModel;
using System;

namespace MasterDirectory.Operaciones.Forms;

[FormScript("Operaciones.CategoriaOperaciones")]
[BasedOnRow(typeof(CategoriaOperacionesRow), CheckNames = true)]
public class CategoriaOperacionesForm
{
    [Tab("General")]
    public string LocalSap { get; set; }
    public string Region { get; set; }
    public string EdoLocal { get; set; }
    public string Zona { get; set; }

    [Tab("Geo")]
    public string Geo { get; set; }
    public string MailGeo { get; set; }
    public string DirectorRegional { get; set; }

    [Tab("Horarios")]
    public string HorarioLv { get; set; }
    public string HorarioS { get; set; }
    public string HorarioDyF { get; set; }
    //public DateTime DtRegistro { get; set; }
}