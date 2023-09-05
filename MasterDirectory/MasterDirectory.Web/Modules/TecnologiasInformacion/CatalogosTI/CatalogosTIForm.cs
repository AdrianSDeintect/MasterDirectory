using Serenity.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace MasterDirectory.TecnologiasInformacion.Forms;

[FormScript("TecnologiasInformacion.CatalogosTI")]
[BasedOnRow(typeof(CatalogosTIRow), CheckNames = true)]
public class CatalogosTIForm
{
    [Editable(false)]
    public int IdtipoCatalogo { get; set; }
    [Editable(false)]
    public int IdClave { get; set; }
    public string Descripcion { get; set; }
    [BooleanEditor]
    public int Activo { get; set; }
    //public DateTime DtRegistro { get; set; }
}