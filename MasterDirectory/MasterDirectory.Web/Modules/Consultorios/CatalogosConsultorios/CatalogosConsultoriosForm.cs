using Serenity.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace MasterDirectory.Consultorios.Forms;

[FormScript("Consultorios.CatalogosConsultorios")]
[BasedOnRow(typeof(CatalogosConsultoriosRow), CheckNames = true)]
public class CatalogosConsultoriosForm
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